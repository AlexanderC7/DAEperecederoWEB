import React from 'react';

const Card = ({ children, className = '' }) => (
  <div className={`bg-white shadow-md rounded-2xl p-6 ${className}`}>
    {children}
  </div>
);

export default Card;