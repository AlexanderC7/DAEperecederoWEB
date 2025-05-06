package com.servidor.supermercado.repositories;

import com.servidor.supermercado.model.Perecedero;
import org.springframework.data.jpa.repository.JpaRepository;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

public interface PerecederosRespository extends JpaRepository<Perecedero, Long> {

    //Busquedas individuales
    Optional<Perecedero> findFirstByNombre(String nombre);
    Optional<Perecedero> findFirstByCodigo(Integer codigo);
    Optional<Perecedero> findFirstByPrecio(Double precio);
    Optional<Perecedero> findFirstByCantidad(Integer cantidad);
    Optional<Perecedero> findFirstByFechaVencimiento(LocalDateTime fechaVencimiento);

    //Busqueda de todos los objetos
    List<Perecedero> findByNombre(String nombre);
    List<Perecedero> findByCodigo(Integer codigo);
    List<Perecedero> findByPrecio(Double precio);
    List<Perecedero> findByCantidad(Integer cantidad);
    List<Perecedero> findByFechaVencimiento(LocalDateTime fecha);
}
