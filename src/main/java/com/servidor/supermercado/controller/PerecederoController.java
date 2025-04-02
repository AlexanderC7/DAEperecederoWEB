package com.servidor.supermercado.controller;

import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.services.ServicioPerecedero;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.function.EntityResponse;

@RestController
@RequestMapping(value = "/perecederos")
public class PerecederoController {

    private ServicioPerecedero servicioPerecedero = new ServicioPerecedero();

    @GetMapping("/")
    public ResponseEntity<String> devolverPrincipal(){
        servicioPerecedero.llenarListaPrueba();
        return ResponseEntity.ok("Perecederos añadidos correctamente");
    }

    @GetMapping("/healthStatus")
    public ResponseEntity<String> devolverEstado(){
        return ResponseEntity.ok("OK");
    }

    @GetMapping("/add")
    public ResponseEntity<String> agregarPerecedero(){
        return ResponseEntity.ok("Producto Creado");
    }

    @GetMapping("/find")
    public String buscarPerecedero(){
        String respuesta;
        respuesta = servicioPerecedero.getPerecederos().toString();
        return respuesta;
    }



}
