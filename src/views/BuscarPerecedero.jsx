// src/views/BuscarPerecedero.jsx

import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";

const BuscarPerecedero = () => {
  const [parametro, setParametro] = useState("nombre");
  const [valor, setValor] = useState("");
  const [resultado, setResultado] = useState(null);
  const [mensaje, setMensaje] = useState("");
  const navigate = useNavigate();

  const handleBuscar = async () => {
    if (!valor) {
      setMensaje("Debe ingresar un valor para buscar");
      return;
    }

    try {
      const response = await axios.get("http://localhost:8080/perecederos/query", {
        params: {
          [parametro]: valor,
        },
      });
      setResultado(response.data);
      setMensaje("");
    } catch (error) {
      if (error.response?.status === 404) {
        setMensaje("Producto no encontrado");
      } else {
        setMensaje("Error al buscar el producto");
      }
      setResultado(null);
    }
  };

  return (
    <div className="min-h-screen flex flex-col items-center justify-center bg-gray-100 p-6">
      <h1 className="text-4xl font-bold text-blue-800 mb-6">Buscar Perecedero</h1>

      <div className="flex flex-col md:flex-row items-center gap-4 mb-4">
        <label className="font-medium">Buscar por:</label>
        <select
          className="p-2 rounded border"
          value={parametro}
          onChange={(e) => setParametro(e.target.value)}
        >
          <option value="nombre">Nombre</option>
          <option value="codigo">Código</option>
          <option value="cantidad">Cantidad</option>
          <option value="precio">Precio</option>
          <option value="fechaVencimiento">Fecha de Vencimiento</option>
        </select>
        <input
          className="p-2 rounded border"
          type="text"
          placeholder="Ingrese valor"
          value={valor}
          onChange={(e) => setValor(e.target.value)}
        />
        <button
          className="bg-blue-600 text-white px-4 py-2 rounded hover:bg-blue-700"
          onClick={handleBuscar}
        >
          Buscar
        </button>
      </div>

      {mensaje && <p className="text-red-500 mb-4">{mensaje}</p>}

      {resultado && (
        <div className="bg-white p-6 rounded shadow-md w-full max-w-lg mt-4">
          <h2 className="text-xl font-semibold mb-2">Resultado:</h2>
          <ul className="space-y-2">
            <li><strong>Nombre:</strong> {resultado.nombre}</li>
            <li><strong>Código:</strong> {resultado.codigo}</li>
            <li><strong>Cantidad:</strong> {resultado.cantidad}</li>
            <li><strong>Precio:</strong> ${resultado.precio}</li>
            <li><strong>Fecha Vencimiento:</strong> {resultado.fechaVencimiento}</li>
          </ul>
        </div>
      )}

      <button
        className="mt-6 bg-gray-500 text-white px-4 py-2 rounded hover:bg-gray-600"
        onClick={() => navigate("/")}
      >
        Volver al Menú
      </button>
    </div>
  );
};

export default BuscarPerecedero;