import { useEffect, useState } from 'react';
import  Card  from '../components/ui/Card';

function ListarLotes() {
  const [lotes, setLotes] = useState([]);
  const [mensaje, setMensaje] = useState('');

  useEffect(() => {
    fetch('http://localhost:8080/lotes/')
      .then((res) => {
        if (!res.ok) throw new Error('Error al obtener los lotes');
        return res.json();
      })
      .then((data) => setLotes(data))
      .catch((err) => setMensaje(' No se pudo conectar con el servidor'));
  }, []);

  return (
    <div className="p-8">
      <h2 className="text-2xl font-bold mb-6 text-center"> Lista de Lotes</h2>
      {mensaje && <p className="text-red-500">{mensaje}</p>}
      {lotes.length === 0 && !mensaje && (
        <p className="text-center text-gray-500">No hay lotes registrados.</p>
      )}
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
        {lotes.map((lote, index) => (
          <Card key={index} className="p-4 shadow-md">
            <p><strong>Número de Lote:</strong> {lote.numLote}</p>
            <p><strong>Proveedor:</strong> {lote.proveedor}</p>
            <p><strong>Fecha Abastecimiento:</strong> {lote.fechaAbastecimiento.replace('T', ' ')}</p>
            <p><strong>Perecedero Código:</strong> {lote.perecedero?.codigo}</p>
          </Card>
        ))}
      </div>
    </div>
  );
}

export default ListarLotes;