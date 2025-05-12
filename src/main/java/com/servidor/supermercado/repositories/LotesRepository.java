package com.servidor.supermercado.repositories;

import com.servidor.supermercado.model.Lote;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface LotesRepository extends JpaRepository<Lote, Long> {
    List<Lote> findByPerecederoId(Long perecederoId);
}
