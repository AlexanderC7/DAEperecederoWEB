package com.servidor.supermercado.repositories;

import com.servidor.supermercado.model.Lote;
import com.servidor.supermercado.model.LoteId;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface LotesRepository extends JpaRepository<Lote, LoteId> {

    // Buscar todos los lotes de un perecedero por su código
    List<Lote> findByPerecederoCodigo(Integer codigo);

    // Buscar lotes por fecha de abastecimiento
    List<Lote> findByFechaAbastecimiento(java.time.LocalDateTime fechaAbastecimiento);

    // Buscar por proveedor
    List<Lote> findByProveedorContainingIgnoreCase(String proveedor);
}