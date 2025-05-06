package com.servidor.supermercado.services;

import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.datatype.jsr310.JavaTimeModule;
import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.repositories.PerecederosRespository;
import lombok.Getter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Getter
@Service
public class ServicioPerecedero {

    @Autowired
    private PerecederosRespository perecederosRespository;

    private ObjectMapper objectMapper = new ObjectMapper();
    private Perecedero resultado;



    public Perecedero buscarPerecedero(String nombre, Integer codigo, Double precio, Integer cantidad, LocalDateTime fechaVencimiento){

        if (nombre != null){
            resultado = buscarPerecederoPorNombre(nombre);
        } else if (codigo != null) {
            resultado = buscarPerecederoPorCodigo(codigo);
        } else if (precio != null) {
            resultado = buscarPerecederoPorPrecio(precio);
        } else if (cantidad != null) {
            resultado = buscarPerecederoPorCantidad(cantidad);
        } else if (fechaVencimiento != null) {
            resultado = buscarPerecederoPorVencimiento(fechaVencimiento);
        } else {
            resultado = null;
        }

        return resultado;
    }

    private Perecedero buscarPerecederoPorNombre(String nombre){
        Optional<Perecedero> busqueda = perecederosRespository.findFirstByNombre(nombre);
        return busqueda.orElse(null);
    }

    private Perecedero buscarPerecederoPorCodigo(Integer codigo){
        Optional<Perecedero> busqueda = perecederosRespository.findFirstByCodigo(codigo);
        return busqueda.orElse(null);
    }

    private Perecedero buscarPerecederoPorPrecio(Double precio){
        Optional<Perecedero> busqueda = perecederosRespository.findFirstByPrecio(precio);
        return busqueda.orElse(null);
    }

    private Perecedero buscarPerecederoPorCantidad(Integer cantidad){
        Optional<Perecedero> busqueda = perecederosRespository.findFirstByCantidad(cantidad);
        return busqueda.orElse(null);
    }

    private Perecedero buscarPerecederoPorVencimiento(LocalDateTime fechaVencimiento){
        Optional<Perecedero> busqueda = perecederosRespository.findFirstByFechaVencimiento(fechaVencimiento);
        return busqueda.orElse(null);
    }

    public Perecedero agregarPerecedero(Perecedero perecedero){
        return perecederosRespository.save(perecedero);
    }

    public boolean eliminarPerecedero(Integer codigo) {
        if (codigo == null) {return false;}

        Perecedero perecedero = buscarPerecederoPorCodigo(codigo);
        if (perecedero == null) {return false;}

        perecederosRespository.delete(perecedero);
        return true;
    }

    public boolean actualizarPerecedero(Perecedero perecedero){
        if (perecedero.getCodigo().equals(resultado.getCodigo())) {
            perecederosRespository.save(perecedero);
            return true;
        }
        return false;
    }

    public JsonNode listarPerecederos(){

        try {
            // Convertir la lista a un JsonNode
            objectMapper.registerModule(new JavaTimeModule());
            return objectMapper.valueToTree(perecederosRespository.findAll());
        } catch (Exception e) {
            e.printStackTrace();
            return objectMapper.nullNode();
        }

    }

    public JsonNode listarPerecederosPorFiltro(String nombre, Integer codigo, Double precio, Integer cantidad, LocalDateTime fechaVencimiento) {
        List<Perecedero> perecederoFiltrado = new ArrayList<>();
        List<Perecedero> listaAuxiliar;

        if (nombre != null){
            listaAuxiliar = listarPerecederoPorNombre(nombre);
            perecederoFiltrado.addAll(listaAuxiliar);
        } if (codigo != null) {
            listaAuxiliar = listarPerecederoPorCodigo(codigo);
            perecederoFiltrado.addAll(listaAuxiliar);
        } if (precio != null) {
            listaAuxiliar = listarPerecederoPorPrecio(precio);
            perecederoFiltrado.addAll(listaAuxiliar);
        } if (cantidad != null) {
            listaAuxiliar = listarPerecederoPorCantidad(cantidad);
            perecederoFiltrado.addAll(listaAuxiliar);
        } if (fechaVencimiento != null) {
            listaAuxiliar = listarPerecederoPorVencimiento(fechaVencimiento);
            perecederoFiltrado.addAll(listaAuxiliar);
        }

        return objectMapper.valueToTree(perecederoFiltrado);
    }

    private List<Perecedero> listarPerecederoPorNombre(String nombre) {
        return perecederosRespository.findByNombre(nombre);
    }

    private List<Perecedero> listarPerecederoPorCodigo(Integer codigo) {
        return perecederosRespository.findByCodigo(codigo);
    }

    private List<Perecedero> listarPerecederoPorPrecio(Double precio) {
        return perecederosRespository.findByPrecio(precio);
    }

    private List<Perecedero> listarPerecederoPorCantidad(Integer cantidad) {
        return perecederosRespository.findByCantidad(cantidad);
    }

    private List<Perecedero> listarPerecederoPorVencimiento(LocalDateTime fechaVencimiento) {
        return perecederosRespository.findByFechaVencimiento(fechaVencimiento);
    }

}
