package com.servidor.supermercado.services;

import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.servidor.supermercado.model.Perecedero;
import lombok.Getter;

import java.time.LocalDateTime;
import java.util.ArrayList;

@Getter
public class ServicioPerecedero {

    private ArrayList<Perecedero> perecederos = new ArrayList<>();
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

    public boolean agregarPerecedero(Perecedero perecedero){
        return perecederos.add(perecedero);
    }

    public boolean eliminarPerecedero(Integer codigo) {
        if (codigo == null) {
            return false;
        }

        Perecedero perecedero = buscarPerecederoPorCodigo(codigo);
        return perecedero != null && perecederos.remove(perecedero);
    }

    public boolean actualizarPerecedero(Perecedero perecedero){
        for (Perecedero perecederoLocal : perecederos){
            if (resultado.equals(perecederoLocal)) {
                perecederoLocal.setNombre(perecedero.getNombre());
                perecederoLocal.setCodigo(perecedero.getCodigo());
                perecederoLocal.setPrecio(perecedero.getPrecio());
                perecederoLocal.setCantidad(perecedero.getCantidad());
                perecederoLocal.setFechaVencimiento(perecedero.getFechaVencimiento());
                return true;
            }
        }
        return false;
    }

    public JsonNode listarPerecederos(){

        try {
            // Convertir la lista a un JsonNode
            return objectMapper.valueToTree(perecederos);
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }

    }

    public JsonNode listarPerecederosPorFiltro(String nombre, Integer codigo, Double precio, Integer cantidad, LocalDateTime fechaVencimiento) {
        ArrayList<Perecedero> perecederoFiltrado;
        perecederoFiltrado = null;

        if (nombre != null){
            perecederoFiltrado = listarPerecederoPorNombre(nombre);
        } if (codigo != null) {
            perecederoFiltrado = listarPerecederoPorCodigo(codigo);
        } if (precio != null) {
            perecederoFiltrado = listarPerecederoPorPrecio(precio);
        } if (cantidad != null) {
            perecederoFiltrado = listarPerecederoPorCantidad(cantidad);
        } if (fechaVencimiento != null) {
            perecederoFiltrado = listarPerecederoPorVencimiento(fechaVencimiento);
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
