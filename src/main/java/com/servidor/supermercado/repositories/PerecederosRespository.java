package com.servidor.supermercado.repositories;

import com.servidor.supermercado.model.Perecedero;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PerecederosRespository extends JpaRepository<Perecedero, Long> {
}
