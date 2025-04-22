import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import { MenuPrincipal } from "./components/MenuPrincipal";
import { AgregarPerecedero } from "./components/AgregarPerecedero";
import { BuscarPerecedero } from "./components/BuscarPerecedero";
import { ActualizarPerecedero } from "./components/ActualizarPerecedero";
import { EliminarPerecedero } from "./components/EliminarPerecedero";
import { ListarTodos } from "./components/ListarTodos";
import { ListarPorFiltro } from "./components/ListarPorFiltro";
import { AcercaDe } from "./components/AcercaDe";

export default function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<MenuPrincipal />} />
        <Route path="/agregar" element={<AgregarPerecedero />} />
        <Route path="/buscar" element={<BuscarPerecedero />} />
        <Route path="/actualizar" element={<ActualizarPerecedero />} />
        <Route path="/eliminar" element={<EliminarPerecedero />} />
        <Route path="/listar" element={<ListarTodos />} />
        <Route path="/filtrar" element={<ListarPorFiltro />} />
        <Route path="/acerca" element={<AcercaDe />} />
      </Routes>
    </Router>
  );
}
