package com.servidor.supermercado.services;

import com.servidor.supermercado.model.Perecedero;
import lombok.Getter;

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
}
