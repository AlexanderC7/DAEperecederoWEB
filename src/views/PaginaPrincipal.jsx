import { Link } from 'react-router-dom';
import Button from '../components/ui/Button';
import Card from '../components/ui/Card';
import { HelpCircle } from 'lucide-react';

export default function PaginaPrincipal() {
  return (
    <div className="min-h-screen bg-gradient-to-br from-green-100 to-green-300 p-6">
      <div className="text-center mb-10">
        <h1 className="text-5xl font-bold text-green-800 drop-shadow-md">
          Supermercado Donde los Electrónicos
        </h1>
        <p className="text-lg mt-2 text-green-700">Sistema de gestión de productos perecederos</p>
      </div>

      <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6 max-w-4xl mx-auto">
        <Card className="p-6 flex flex-col items-center">
          <Link to="/agregar">
            <Button className="w-40">Agregar</Button>
          </Link>
        </Card>
        <Card className="p-6 flex flex-col items-center">
          <Link to="/buscar">
            <Button className="w-40">Buscar</Button>
          </Link>
        </Card>
        <Card className="p-6 flex flex-col items-center">
          <Link to="/actualizar">
            <Button className="w-40">Actualizar</Button>
          </Link>
        </Card>
        <Card className="p-6 flex flex-col items-center">
          <Link to="/eliminar">
            <Button className="w-40">Eliminar</Button>
          </Link>
        </Card>
        <Card className="p-6 flex flex-col items-center">
          <Link to="/listar">
            <Button className="w-40">Listar Todos</Button>
          </Link>
        </Card>
        <Card className="p-6 flex flex-col items-center">
          <Link to="/listar-filtro">
            <Button className="w-40">Listar con Filtro</Button>
          </Link>
        </Card>
      </div>

      <div className="mt-10 text-center">
        <button
          className="text-sm text-green-800 hover:underline flex items-center justify-center gap-2"
          onClick={() => {
            alert('ACERCA DE \nAplicación v2.0\nEquipo: \n> Alejandro Vargas\n> Leandro Vergara\n> Jhon Cartagena\n> Juan FLorez');
          }}
        >
          <HelpCircle className="w-4 h-4" /> Ayuda
        </button>
      </div>
    </div>
  );
}