import  useState  from 'react';
import  Input  from '../components/ui/Input';
import  Button  from '../components/ui/Button';
import  Card  from '../components/ui/Card';

function BuscarLote() {
  const [numLote, setNumLote] = useState('');
  const [perecederoCodigo, setPerecederoCodigo] = useState('');
  const [resultado, setResultado] = useState(null);
  const [mensaje, setMensaje] = useState('');

  const handleBuscar = async () => {
    setMensaje('');
    setResultado(null);

    if (!numLote || !perecederoCodigo) {
      setMensaje(' Ingresa ambos campos');
      return;
    }

    try {
      const response = await fetch(`http://localhost:8080/lotes/${numLote}/${perecederoCodigo}`);
      if (response.ok) {
        const data = await response.json();
        setResultado(data);
      } else {
        setMensaje(' Lote no encontrado');
      }
    } catch (error) {
      setMensaje('Error de conexión con el servidor');
    }
  };

  return (
    <div className="flex justify-center items-center h-screen">
      <Card className="p-8 w-full max-w-md shadow-lg">
        <h2 className="text-2xl font-bold mb-6">Buscar Lote</h2>
        <div className="space-y-4">
          <Input
            type="number"
            placeholder="Número de Lote"
            value={numLote}
            onChange={(e) => setNumLote(e.target.value)}
            required
          />
          <Input
            type="number"
            placeholder="Código de Perecedero"
            value={perecederoCodigo}
            onChange={(e) => setPerecederoCodigo(e.target.value)}
            required
          />
          <Button onClick={handleBuscar}>Buscar</Button>
        </div>
        {mensaje && <p className="mt-4 text-sm text-red-500">{mensaje}</p>}
        {resultado && (
          <div className="mt-6 text-sm bg-gray-100 p-4 rounded-md">
            <p><strong>Num Lote:</strong> {resultado.numLote}</p>
            <p><strong>Proveedor:</strong> {resultado.proveedor}</p>
            <p><strong>Fecha Abastecimiento:</strong> {new Date(resultado.fechaAbastecimiento).toLocaleString()}</p>
            <p><strong>Código Perecedero:</strong> {resultado.perecedero?.codigo}</p>
          </div>
        )}
      </Card>
    </div>
  );
}

export default BuscarLote;