import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios';
import Input  from '../components/ui/Input';
import Button from '../components/ui/Button';

function ActualizarPerecedero() {
  const [codigoBusqueda, setCodigoBusqueda] = useState('');
  const [perecedero, setPerecedero] = useState(null);
  const [mensaje, setMensaje] = useState('');
  const navigate = useNavigate();

  const handleBuscar = async () => {
    try {
      const response = await axios.get('http://localhost:8080/perecederos/query', {
        params: { codigo: codigoBusqueda },
      });
      setPerecedero(response.data);
      setMensaje('');
    } catch (error) {
      setPerecedero(null);
      if (error.response?.status === 404) {
        setMensaje('Perecedero no encontrado.');
      } else {
        setMensaje('Error al buscar perecedero.');
      }
    }
  };

  const handleActualizar = async () => {
    try {
      await axios.put('http://localhost:8080/perecederos', perecedero);
      setMensaje('Perecedero actualizado correctamente.');
    } catch (error) {
      setMensaje('Error al actualizar perecedero.');
    }
  };

  return (
    <div className="p-6 max-w-2xl mx-auto">
      <h2 className="text-2xl font-bold mb-4">Actualizar Perecedero</h2>

      <div className="mb-4">
        <Input
          type="number"
          placeholder="Código a buscar"
          value={codigoBusqueda}
          onChange={(e) => setCodigoBusqueda(e.target.value)}
        />
        <Button className="mt-2" onClick={handleBuscar}>Buscar</Button>
      </div>

      {perecedero && (
        <div className="space-y-3">
          <Input
            type="text"
            placeholder="Nombre"
            value={perecedero.nombre}
            onChange={(e) => setPerecedero({ ...perecedero, nombre: e.target.value })}
          />
          <Input
            type="number"
            placeholder="Cantidad"
            value={perecedero.cantidad}
            onChange={(e) => setPerecedero({ ...perecedero, cantidad: parseInt(e.target.value) })}
          />
          <Input
            type="number"
            placeholder="Precio"
            value={perecedero.precio}
            onChange={(e) => setPerecedero({ ...perecedero, precio: parseFloat(e.target.value) })}
          />
          <Input
            type="datetime-local"
            value={perecedero.fechaVencimiento?.slice(0, 16)}
            onChange={(e) => setPerecedero({ ...perecedero, fechaVencimiento: e.target.value })}
          />
          <Button className="w-full" onClick={handleActualizar}>Actualizar</Button>
        </div>
      )}

      {mensaje && <p className="mt-4 text-red-600 font-medium">{mensaje}</p>}
      <Button variant="secondary" className="mt-6" onClick={() => navigate('/')}>Volver al Inicio</Button>
    </div>
  );
}

export default ActualizarPerecedero;