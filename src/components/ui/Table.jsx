import React from 'react';

const Table = ({ headers = [], data = [] }) => (
  <div className="overflow-x-auto">
    <table className="min-w-full bg-white rounded-lg shadow">
      <thead>
        <tr>
          {headers.map((header, idx) => (
            <th key={idx} className="px-4 py-2 border-b bg-gray-100 text-left font-semibold text-gray-700">
              {header}
            </th>
          ))}
        </tr>
      </thead>
      <tbody>
        {data.map((row, idx) => (
          <tr key={idx} className="hover:bg-gray-50">
            {Object.values(row).map((cell, cellIdx) => (
              <td key={cellIdx} className="px-4 py-2 border-b text-gray-800">{cell}</td>
            ))}
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

export default Table;