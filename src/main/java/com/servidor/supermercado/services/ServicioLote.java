package com.servidor.supermercado.services;

import com.servidor.supermercado.model.Lote;
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

    public Optional<Lote> buscarPorId(Long id) {
        return lotesRepository.findById(id);
    }

    public List<Lote> buscarPorPerecedero(Long perecederoId) {
        return lotesRepository.findByPerecederoId(perecederoId);
    }

    public List<Lote> listarTodos() {
        return lotesRepository.findAll();
    }

    public Lote guardarLote(Long perecederoId, Lote lote) {
        Optional<Perecedero> perecedero = perecederosRepository.findById(perecederoId);
        if (perecedero.isPresent()) {
            lote.setPerecedero(perecedero.get());
            return lotesRepository.save(lote);
        }
        return null;
    }

    public boolean actualizarLote(Long id, Lote nuevoLote) {
        Optional<Lote> existente = lotesRepository.findById(id);
        if (existente.isPresent()) {
            Lote loteExistente = existente.get();
            loteExistente.setNumLote(nuevoLote.getNumLote());
            loteExistente.setProveedor(nuevoLote.getProveedor());
            lotesRepository.save(loteExistente);
            return true;
        }
        return false;
    }

    public boolean eliminarLote(Long id) {
        if (lotesRepository.existsById(id)) {
            lotesRepository.deleteById(id);
            return true;
        }
        return false;
    }
}