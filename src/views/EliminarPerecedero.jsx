import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios';

const EliminarPerecedero = () => {
  const [codigo, setCodigo] = useState('');
  const [producto, setProducto] = useState(null);
  const [mensaje, setMensaje] = useState('');
  const navigate = useNavigate();

  const buscarProducto = async () => {
    try {
      const response = await axios.get(`http://localhost:8080/perecederos/query?codigo=${codigo}`);
      setProducto(response.data);
      setMensaje('Producto encontrado');
    } catch (error) {
      setProducto(null);
      if (error.response?.status === 404) {
        setMensaje('Producto no encontrado');
      } else {
        setMensaje('Error al buscar producto');
      }
    }
  };

  const eliminarProducto = async () => {
    try {
      await axios.delete(`http://localhost:8080/perecederos/${codigo}`);
      setMensaje('Producto eliminado correctamente');
      setProducto(null);
      setCodigo('');
    } catch (error) {
      if (error.response?.status === 404) {
        setMensaje('Producto no encontrado para eliminar');
      } else {
        setMensaje('Error al eliminar producto');
      }
    }
  };

  return (
    <div className="container mx-auto p-4 max-w-xl">
      <h2 className="text-2xl font-bold mb-4">Eliminar Perecedero</h2>

      <input
        type="number"
        placeholder="Ingrese código"
        value={codigo}
        onChange={(e) => setCodigo(e.target.value)}
        className="border p-2 rounded w-full mb-2"
      />
      <button
        onClick={buscarProducto}
        className="bg-blue-500 hover:bg-blue-600 text-white px-4 py-2 rounded mb-4"
      >
        Buscar
      </button>

      {producto && (
        <div className="border p-4 rounded shadow mb-4">
          <p><strong>Nombre:</strong> {producto.nombre}</p>
          <p><strong>Código:</strong> {producto.codigo}</p>
          <p><strong>Cantidad:</strong> {producto.cantidad}</p>
          <p><strong>Precio:</strong> {producto.precio}</p>
          <p><strong>Fecha de Vencimiento:</strong> {producto.fechaVencimiento}</p>

          <button
            onClick={eliminarProducto}
            className="bg-red-500 hover:bg-red-600 text-white px-4 py-2 mt-4 rounded"
          >
            Eliminar Producto
          </button>
        </div>
      )}

      {mensaje && <p className="text-sm text-gray-700">{mensaje}</p>}

      <button
        onClick={() => navigate('/')}
        className="bg-gray-400 hover:bg-gray-500 text-white px-4 py-2 rounded mt-4"
      >
        Volver al Menú
      </button>
    </div>
  );
};

export default EliminarPerecedero;