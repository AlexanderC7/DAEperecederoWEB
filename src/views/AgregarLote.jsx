import  useState  from 'react';
import  Input  from '../components/ui/Input';
import  Button  from '../components/ui/Button';
import  Card  from '../components/ui/Card';

function AgregarLote() {
  const [numLote, setNumLote] = useState('');
  const [proveedor, setProveedor] = useState('');
  const [fechaAbastecimiento, setFechaAbastecimiento] = useState('');
  const [perecederoCodigo, setPerecederoCodigo] = useState('');
  const [mensaje, setMensaje] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    setMensaje('');

    const lote = {
      numLote: parseInt(numLote),
      proveedor,
      fechaAbastecimiento,
    };

    try {
      const response = await fetch(`http://localhost:8080/lotes/${perecederoCodigo}`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(lote),
      });

      const data = await response.json();
      if (response.ok) {
        setMensaje(' Lote agregado correctamente');
      } else {
        setMensaje(` Error: ${Array.isArray(data) ? data.join(', ') : data}`);
      }
    } catch (error) {
      setMensaje(' Error de conexión con el servidor');
    }
  };

  return (
    <div className="flex justify-center items-center h-screen">
      <Card className="p-8 w-full max-w-md shadow-xl">
        <h2 className="text-2xl font-bold mb-6">Agregar Lote</h2>
        <form onSubmit={handleSubmit} className="space-y-4">
          <Input
            type="number"
            placeholder="Número de Lote"
            value={numLote}
            onChange={(e) => setNumLote(e.target.value)}
            required
          />
          <Input
            type="text"
            placeholder="Proveedor"
            value={proveedor}
            onChange={(e) => setProveedor(e.target.value)}
            required
          />
          <Input
            type="datetime-local"
            value={fechaAbastecimiento}
            onChange={(e) => setFechaAbastecimiento(e.target.value)}
            required
          />
          <Input
            type="number"
            placeholder="Código de Perecedero"
            value={perecederoCodigo}
            onChange={(e) => setPerecederoCodigo(e.target.value)}
            required
          />
          <Button type="submit">Agregar</Button>
        </form>
        {mensaje && <p className="mt-4 text-sm">{mensaje}</p>}
      </Card>
    </div>
  );
}

export default AgregarLote;