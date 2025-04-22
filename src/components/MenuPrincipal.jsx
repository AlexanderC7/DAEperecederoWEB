// src/components/MenuPrincipal.jsx
import { Link } from "react-router-dom";

export function MenuPrincipal() {
  return (
    <div className="min-h-screen bg-blue-50 flex flex-col items-center justify-center">
      <h1 className="text-4xl font-bold mb-10 text-blue-800">
        Supermercado Donde los Electrónicos
      </h1>
      <nav className="grid grid-cols-2 gap-4 text-center">
        <Link to="/agregar" className="btn">Agregar Perecedero</Link>
        <Link to="/buscar" className="btn">Buscar Perecedero</Link>
        <Link to="/actualizar" className="btn">Actualizar Perecedero</Link>
        <Link to="/eliminar" className="btn">Eliminar Perecedero</Link>
        <Link to="/listar" className="btn">Listar Todos</Link>
        <Link to="/filtrar" className="btn">Listar por Filtro</Link>
        <Link to="/acerca" className="btn">Acerca de...</Link>
      </nav>
    </div>
  );
}