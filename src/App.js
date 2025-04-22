import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import PaginaPrincipal from './views/PaginaPrincipal';
import BuscarPerecedero from './views/BuscarPerecedero';
import AgregarPerecedero from './views/AgregarPerecedero';
import ActualizarPerecedero from './views/ActualizarPerecedero';
import EliminarPerecedero from './views/EliminarPerecedero';
import ListarPerecederos from './views/ListarPerecedero';
import ListarConFiltro from './views/ListarConFiltroPerecedero';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<PaginaPrincipal />} />
        <Route path='/buscar' element={<BuscarPerecedero />} />
        <Route path='/agregar' element={<AgregarPerecedero />} />
        <Route path='/actualizar' element={<ActualizarPerecedero />} />
        <Route path='/eliminar' element={<EliminarPerecedero />} />
        <Route path='/listar' element={<ListarPerecederos />} />
        <Route path='/listar-filtro' element={<ListarConFiltro />} />
      </Routes>
    </Router>
  );
}

export default App;