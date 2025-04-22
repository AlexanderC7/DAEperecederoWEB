// src/pages/ListarConFiltroPerecederos.jsx

import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const ListarConFiltroPerecederos = () => {
  const [filtro, setFiltro] = useState('');
  const [valorFiltro, setValorFiltro] = useState('');
  const [perecederos, setPerecederos] = useState([]);
  const [mensaje, setMensaje] = useState('');
  const navigate = useNavigate();

  const manejarListadoPorFiltro = async () => {
    try {
      let url = 'http://localhost:8080/perecederos';
      if (filtro && valorFiltro) {
        url += `?${filtro}=${encodeURIComponent(valorFiltro)}`;
      }

      const response = await axios.get(url);
      if (response.status === 204) {
        setPerecederos([]);
        setMensaje('No se encontraron productos con ese filtro.');
      } else {
        setPerecederos(response.data);
        setMensaje('');
      }
    } catch (error) {
      setMensaje('Error al conectar con el servidor.');
    }
  };

  const regresar = () => navigate('/');

  return (
    <div className="p-6">
      <h1 className="text-2xl font-bold mb-4">Listar Perecederos con Filtro</h1>
      <div className="mb-4">
        <label className="block mb-1">Parámetro de filtro:</label>
        <select
          className="border p-2 mr-2"
          value={filtro}
          onChange={(e) => setFiltro(e.target.value)}
        >
          <option value="">(Ninguno)</option>
          <option value="nombre">Nombre</option>
          <option value="codigo">Código</option>
          <option value="cantidad">Cantidad</option>
          <option value="precio">Precio</option>
          <option value="fechaVencimiento">Fecha Vencimiento</option>
        </select>
        <input
          type="text"
          placeholder="Valor"
          className="border p-2 mr-2"
          value={valorFiltro}
          onChange={(e) => setValorFiltro(e.target.value)}
        />
        <button onClick={manejarListadoPorFiltro} className="bg-blue-600 text-white px-4 py-2 rounded">
          Filtrar
        </button>
      </div>

      {mensaje && <p className="text-red-600 mb-4">{mensaje}</p>}

      {perecederos.length > 0 && (
        <div className="overflow-x-auto">
          <table className="min-w-full bg-white shadow-md rounded-lg overflow-hidden">
            <thead>
              <tr className="bg-gray-200 text-left">
                <th className="py-2 px-4">Código</th>
                <th className="py-2 px-4">Nombre</th>
                <th className="py-2 px-4">Cantidad</th>
                <th className="py-2 px-4">Precio</th>
                <th className="py-2 px-4">Fecha Vencimiento</th>
              </tr>
            </thead>
            <tbody>
              {perecederos.map((p) => (
                <tr key={p.codigo} className="border-t hover:bg-gray-50">
                  <td className="py-2 px-4">{p.codigo}</td>
                  <td className="py-2 px-4">{p.nombre}</td>
                  <td className="py-2 px-4">{p.cantidad}</td>
                  <td className="py-2 px-4">${p.precio.toFixed(2)}</td>
                  <td className="py-2 px-4">{p.fechaVencimiento}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      )}

      <button onClick={regresar} className="mt-6 bg-gray-600 text-white px-4 py-2 rounded">
        Regresar
      </button>
    </div>
  );
};

export default ListarConFiltroPerecederos;