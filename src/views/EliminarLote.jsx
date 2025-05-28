import  useState  from 'react';
import  Input  from '../components/ui/Input';
import  Button  from '../components/ui/Button';
import  Card  from '../components/ui/Card';

function EliminarLote() {
  const [numLote, setNumLote] = useState('');
  const [perecederoCodigo, setPerecederoCodigo] = useState('');
  const [mensaje, setMensaje] = useState('');

  const handleEliminar = async () => {
    setMensaje('');

    if (!numLote || !perecederoCodigo) {
      setMensaje(' Ingresa ambos campos');
      return;
    }

    try {
      const response = await fetch(`http://localhost:8080/lotes/${numLote}/${perecederoCodigo}`, {
        method: 'DELETE',
      });

      if (response.ok) {
        setMensaje(' Lote eliminado correctamente');
        setNumLote('');
        setPerecederoCodigo('');
      } else {
        const texto = await response.text();
        setMensaje(` ${texto}`);
      }
    } catch (error) {
      setMensaje(' Error de conexión con el servidor');
    }
  };

  return (
    <div className="flex justify-center items-center h-screen">
      <Card className="p-8 w-full max-w-md shadow-lg">
        <h2 className="text-2xl font-bold mb-6">Eliminar Lote</h2>
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
          <Button onClick={handleEliminar} className="bg-red-600 hover:bg-red-700">
            Eliminar
          </Button>
        </div>
        {mensaje && <p className="mt-4 text-sm text-red-500">{mensaje}</p>}
      </Card>
    </div>
  );
}

export default EliminarLote;