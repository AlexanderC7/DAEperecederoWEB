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
        for (int i = 0; i < perecederos.size(); i++) {
            if (nombre.equals(perecederos.get(i).getNombre())) {
                return perecederos.get(i);
            }
        }
    }

    private Perecedero buscarPerecederoPorCodigo(Integer codigo){
        //Aqui por codigo
        return null;
    }

    private Perecedero buscarPerecederoPorPrecio(Double precio){
        //Aqui por precio
        return null;
    }

    private Perecedero buscarPerecederoPorCantidad(Integer cantidad){
        //Aqui por cantidad
        return null;
    }

    private Perecedero buscarPerecederoPorVencimiento(LocalDateTime fechaVencimiento){
        //Aqui por la fecha de vencimiento
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
