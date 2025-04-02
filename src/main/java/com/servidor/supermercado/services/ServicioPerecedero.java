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

    public void llenarListaPrueba(){
        Perecedero pere1 = new Perecedero("Bocadillo", 123, 2000.0, 2, LocalDateTime.now());
        perecederos.add(pere1);
        Perecedero pere2 = new Perecedero("Leche", 124, 9200.0, 10, LocalDateTime.now());
        perecederos.add(pere2);
    }

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
        //Aqui por nombre
        return null;
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
}
