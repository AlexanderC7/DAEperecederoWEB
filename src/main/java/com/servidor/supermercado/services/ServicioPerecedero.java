package com.servidor.supermercado.services;

import com.servidor.supermercado.model.Perecedero;
import lombok.Getter;
import org.springframework.cglib.core.Local;
import org.springframework.core.annotation.AnnotationUtils;

import java.time.LocalDateTime;
import java.util.ArrayList;

@Getter
public class ServicioPerecedero {

    private ArrayList<Perecedero> perecederos = new ArrayList<>();

    public Perecedero buscarPerecedero(String nombre, Integer codigo, Double precio, Integer cantidad, LocalDateTime fechaVencimiento){
        Perecedero resultado;

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

    public Perecedero agregarPerecedero(){
        //Codigo
        return null;
    }

    public ArrayList<Perecedero> listarPerecederos(){
        return  null;
    }
}
