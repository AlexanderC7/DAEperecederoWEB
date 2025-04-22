import { useState } from "react";
import { useNavigate } from "react-router-dom";

export function AgregarPerecedero() {
  const navigate = useNavigate();
  const [form, setForm] = useState({
    nombre: "",
    codigo: "",
    cantidad: "",
    precio: "",
    fechaVencimiento: ""
  });
  const [mensaje, setMensaje] = useState("");

  const handleChange = (e) => {
    const { name, value } = e.target;
    setForm({ ...form, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setMensaje("");

    // Validaciones
    if (!form.nombre || !form.codigo || !form.cantidad || !form.precio || !form.fechaVencimiento) {
      setMensaje("Todos los campos son obligatorios");
      return;
    }

    try {
      const res = await fetch("http://localhost:8080/perecederos", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          nombre: form.nombre,
          codigo: parseInt(form.codigo),
          cantidad: parseInt(form.cantidad),
          precio: parseFloat(form.precio),
          fechaVencimiento: form.fechaVencimiento
        })
      });
      const data = await res.text();
      if (res.ok) {
        alert("Perecedero agregado exitosamente");
        navigate("/");
      } else {
        setMensaje(data);
      }
    } catch (error) {
      setMensaje("Error de conexión con el servidor");
    }
  };

  return (
    <div className="max-w-xl mx-auto mt-10 p-6 bg-white rounded shadow">
      <h2 className="text-2xl font-bold mb-6 text-center">Agregar Perecedero</h2>
      <form onSubmit={handleSubmit} className="grid gap-4">
        <input type="text" name="nombre" placeholder="Nombre" value={form.nombre} onChange={handleChange} className="input" />
        <input type="number" name="codigo" placeholder="Código" value={form.codigo} onChange={handleChange} className="input" />
        <input type="number" name="cantidad" placeholder="Cantidad" value={form.cantidad} onChange={handleChange} className="input" />
        <input type="number" step="0.01" name="precio" placeholder="Precio" value={form.precio} onChange={handleChange} className="input" />
        <input type="datetime-local" name="fechaVencimiento" value={form.fechaVencimiento} onChange={handleChange} className="input" />
        <button type="submit" className="btn">Agregar</button>
        {mensaje && <p className="text-red-500">{mensaje}</p>}
      </form>
    </div>
  );
}

export default AgregarPerecedero;