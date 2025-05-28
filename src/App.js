import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import PaginaPrincipal from './views/PaginaPrincipal';
import BuscarPerecedero from './views/BuscarPerecedero';
import AgregarPerecedero from './views/AgregarPerecedero';
import ActualizarPerecedero from './views/ActualizarPerecedero';
import EliminarPerecedero from './views/EliminarPerecedero';
import ListarPerecederos from './views/ListarPerecedero';
import ListarConFiltro from './views/ListarConFiltroPerecedero';

import AgregarLote from './views/AgregarLote';
import ActualizarLote from './views/ActualizarLote';
import BuscarLote from './views/BuscarLote';
import ListarLotes from './views/ListarLotes';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<PaginaPrincipal />} />
        <Route path='/perecederos/buscar' element={<BuscarPerecedero />} />
        <Route path='/perecederos/agregar' element={<AgregarPerecedero />} />
        <Route path='/perecederos/actualizar' element={<ActualizarPerecedero />} />
        <Route path='/perecederos/eliminar' element={<EliminarPerecedero />} />
        <Route path='/perecederos/listar' element={<ListarPerecederos />} />
        <Route path='/perecederos/listar-filtro' element={<ListarConFiltro />} />
        <Route path="/lotes/agregar" element={<AgregarLote />} />
        <Route path="/lotes/actualizar" element={<ActualizarLote />} />
        <Route path="/lotes/buscar" element={<BuscarLote />} />
        <Route path="/lotes/listar" element={<ListarLotes />} />
      </Routes>
    </Router>
  );
}

export default App;