package com.servidor.supermercado.services;

import com.servidor.supermercado.model.Lote;
import com.servidor.supermercado.model.LoteId;
import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.repositories.LotesRepository;
import com.servidor.supermercado.repositories.PerecederosRespository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ServicioLote {

    @Autowired
    private LotesRepository lotesRepository;

    @Autowired
    private PerecederosRespository perecederosRepository;

    public Optional<Lote> buscarPorId(LoteId id) {
        return lotesRepository.findById(id);
    }

    public List<Lote> buscarPorPerecedero(Integer perecederoCodigo) {
        return lotesRepository.findByPerecederoCodigo(perecederoCodigo);
    }

    public List<Lote> buscarPorFechaAbastecimiento(java.time.LocalDateTime fecha) {
        return lotesRepository.findByFechaAbastecimiento(fecha);
    }

    public List<Lote> listarTodos() {
        return lotesRepository.findAll();
    }

    public Lote guardarLote(Integer perecederoCodigo, Lote lote) {
        Optional<Perecedero> perecedero = perecederosRepository.findFirstByCodigo(perecederoCodigo);
        if (perecedero.isPresent()) {
            lote.setPerecedero(perecedero.get());

            LoteId id = new LoteId(lote.getNumLote(), perecederoCodigo);
            lote.setId(id);

            return lotesRepository.save(lote);
        }
        return null;
    }


    public boolean actualizarLote(LoteId id, Lote nuevoLote) {
        Optional<Lote> existente = lotesRepository.findById(id);
        if (existente.isPresent()) {
            Lote loteExistente = existente.get();
            loteExistente.setProveedor(nuevoLote.getProveedor());
            loteExistente.setFechaAbastecimiento(nuevoLote.getFechaAbastecimiento());
            lotesRepository.save(loteExistente);
            return true;
        }
        return false;
    }

    public boolean eliminarLote(LoteId id) {
        if (lotesRepository.existsById(id)) {
            lotesRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
