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
        for (Perecedero perecedero : perecederos) {
            if (nombre.equals(perecedero.getNombre())) {
                return perecedero;
            }
        }
        return null;
    }

    private Perecedero buscarPerecederoPorCodigo(Integer codigo){
        for (Perecedero perecedero : perecederos) {
            if (codigo.equals(perecedero.getCodigo())) {
                return perecedero;
            }
        }
        return null;
    }

    private Perecedero buscarPerecederoPorPrecio(Double precio){
        for (Perecedero perecedero : perecederos) {
            if (precio.equals(perecedero.getPrecio())) {
                return perecedero;
            }
        }
        return null;
    }

    private Perecedero buscarPerecederoPorCantidad(Integer cantidad){
        for (Perecedero perecedero : perecederos) {
            if (cantidad.equals(perecedero.getCantidad())) {
                return perecedero;
            }
        }
        return null;
    }

    private Perecedero buscarPerecederoPorVencimiento(LocalDateTime fechaVencimiento){
        for (Perecedero perecedero : perecederos) {
            if (fechaVencimiento.equals(perecedero.getFechaVencimiento())) {
                return perecedero;
            }
        }
        return null;
    }

    public Perecedero agregarPerecedero(Perecedero perecedero){
        return perecederosRespository.save(perecedero);
    }

    public boolean eliminarPerecedero(Integer codigo) {
        if (codigo == null) {
            return false;
        }

        Perecedero perecedero = buscarPerecederoPorCodigo(codigo);
        return perecedero != null && perecederos.remove(perecedero);
    }

    public boolean actualizarPerecedero(Perecedero perecedero){
        perecederosRespository
        /*
        perecederoLocal.setNombre(perecedero.getNombre());
        perecederoLocal.setCodigo(perecedero.getCodigo());
        perecederoLocal.setPrecio(perecedero.getPrecio());
        perecederoLocal.setCantidad(perecedero.getCantidad());
        perecederoLocal.setFechaVencimiento(perecedero.getFechaVencimiento());
        */
        return false;
    }

    public JsonNode listarPerecederos(){

        try {
            // Convertir la lista a un JsonNode
            objectMapper.registerModule(new JavaTimeModule());
            return objectMapper.valueToTree(perecederos);
        } catch (Exception e) {
            e.printStackTrace();
            return objectMapper.nullNode();
        }

    }

    public JsonNode listarPerecederosPorFiltro(String nombre, Integer codigo, Double precio, Integer cantidad, LocalDateTime fechaVencimiento) {
        ArrayList<Perecedero> perecederoFiltrado = new ArrayList<>();
        ArrayList<Perecedero> listaAuxiliar;

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

    private ArrayList<Perecedero> listarPerecederoPorNombre(String nombre) {
        ArrayList<Perecedero> resultados = new ArrayList<>();
        for (Perecedero perecedero : perecederos){
            if (nombre.equals(perecedero.getNombre())) {
                resultados.add(perecedero);
            }
        }
        return resultados;
    }

    private ArrayList<Perecedero> listarPerecederoPorCodigo(Integer codigo) {
        ArrayList<Perecedero> resultados = new ArrayList<>();
        for (Perecedero perecedero : perecederos){
            if (codigo.equals(perecedero.getCodigo())) {
                resultados.add(perecedero);
            }
        }
        return resultados;
    }

    private ArrayList<Perecedero> listarPerecederoPorPrecio(Double precio) {
        ArrayList<Perecedero> resultados = new ArrayList<>();
        for (Perecedero perecedero : perecederos){
            if (precio.equals(perecedero.getPrecio())) {
                resultados.add(perecedero);
            }
        }
        return resultados;
    }

    private ArrayList<Perecedero> listarPerecederoPorCantidad(Integer cantidad) {
        ArrayList<Perecedero> resultados = new ArrayList<>();
        for (Perecedero perecedero : perecederos){
            if (cantidad.equals(perecedero.getCantidad())) {
                resultados.add(perecedero);
            }
        }
        return resultados;
    }

    private ArrayList<Perecedero> listarPerecederoPorVencimiento(LocalDateTime fechaVencimiento) {
        ArrayList<Perecedero> resultados = new ArrayList<>();
        for (Perecedero perecedero : perecederos){
            if (fechaVencimiento.equals(perecedero.getFechaVencimiento())) {
                resultados.add(perecedero);
            }
        }
        return resultados;
    }

}
