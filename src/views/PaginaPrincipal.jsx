import { Link } from 'react-router-dom';

function PaginaPrincipal() {
  return (
    <div className="min-h-screen flex flex-col items-center justify-center bg-gray-100 p-8">
      <h1 className="text-4xl font-bold mb-8 text-center text-blue-600">🛒 Sistema de Gestión de Supermercado</h1>

      {/* Sección Perecederos */}
      <div className="bg-white rounded-2xl shadow-md p-6 w-full max-w-2xl mb-10">
        <h2 className="text-2xl font-semibold text-gray-800 mb-4">🥬 Opciones de Perecedero</h2>
        <div className="grid grid-cols-1 sm:grid-cols-2 gap-4">
          <Link to="/perecederos/agregar" className="btn-option">➕ Agregar Perecedero</Link>
          <Link to="/perecederos/actualizar" className="btn-option">🔄 Actualizar Perecedero</Link>
          <Link to="/perecederos/buscar" className="btn-option">🔍 Buscar Perecedero</Link>
          <Link to="/perecederos/eliminar" className="btn-option">❌ Eliminar Perecedero</Link>
          <Link to="/perecederos/listar" className="btn-option col-span-1 sm:col-span-2">📋 Listar Perecederos</Link>
        </div>
      </div>

      {/* Sección Lotes */}
      <div className="bg-white rounded-2xl shadow-md p-6 w-full max-w-2xl">
        <h2 className="text-2xl font-semibold text-gray-800 mb-4">📦 Opciones de Lote</h2>
        <div className="grid grid-cols-1 sm:grid-cols-2 gap-4">
          <Link to="/lotes/agregar" className="btn-option">➕ Agregar Lote</Link>
          <Link to="/lotes/actualizar" className="btn-option">🔄 Actualizar Lote</Link>
          <Link to="/lotes/buscar" className="btn-option">🔍 Buscar Lote</Link>
          <Link to="/lotes/eliminar" className="btn-option">❌ Eliminar Lote</Link>
          <Link to="/lotes/listar" className="btn-option col-span-1 sm:col-span-2">📋 Listar Lotes</Link>
        </div>
      </div>
    </div>
  );
}

export default PaginaPrincipal;