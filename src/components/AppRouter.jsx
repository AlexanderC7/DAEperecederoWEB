import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import { AgregarPerecedero } from "../views/AgregarPerecedero";
import { BuscarPerecedero } from "./BuscarPerecedero";
import { ActualizarPerecedero } from "./ActualizarPerecedero";
import { EliminarPerecedero } from "./EliminarPerecedero";
import { ListarPerecederos } from "./ListarPerecederos";
import { ListarPorFiltro } from "./ListarPorFiltro";
import { AcercaDe } from "./AcercaDe";

export default function AppRouter() {
  return (
    <Router>
      <div className="min-h-screen bg-gray-100">
        <header className="bg-blue-800 text-white py-6 shadow">
          <h1 className="text-4xl text-center font-bold">Supermercado Donde los electrónicos</h1>
        </header>

        <nav className="bg-white shadow px-4 py-3 flex justify-center gap-4">
          <Link to="/" className="btn-nav">Inicio</Link>
          <Link to="/agregar" className="btn-nav">Agregar</Link>
          <Link to="/buscar" className="btn-nav">Buscar</Link>
          <Link to="/actualizar" className="btn-nav">Actualizar</Link>
          <Link to="/eliminar" className="btn-nav">Eliminar</Link>
          <Link to="/listar" className="btn-nav">Listar Todos</Link>
          <Link to="/filtro" className="btn-nav">Listar por Filtro</Link>
          <Link to="/acerca" className="btn-nav">Acerca de...</Link>
        </nav>

        <main className="p-6">
          <Routes>
            <Route path="/" element={<div className="text-center text-lg">Selecciona una opción del menú</div>} />
            <Route path="/agregar" element={<AgregarPerecedero />} />
            <Route path="/buscar" element={<BuscarPerecedero />} />
            <Route path="/actualizar" element={<ActualizarPerecedero />} />
            <Route path="/eliminar" element={<EliminarPerecedero />} />
            <Route path="/listar" element={<ListarPerecederos />} />
            <Route path="/filtro" element={<ListarPorFiltro />} />
            <Route path="/acerca" element={<AcercaDe />} />
          </Routes>
        </main>
      </div>
    </Router>
  );
}