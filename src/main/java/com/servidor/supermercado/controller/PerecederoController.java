package com.servidor.supermercado.controller;

import com.fasterxml.jackson.databind.JsonNode;
import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.services.ServicioPerecedero;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDateTime;
import java.util.List;

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
    public ResponseEntity<Perecedero> buscarPerecedero(@RequestParam(required = false) String nombre, @RequestParam(required = false) Integer codigo, @RequestParam(required = false) Double precio, @RequestParam(required = false) Integer cantidad, @RequestParam(required = false) LocalDateTime fechaVencimiento){
        if (nombre == null && codigo == null && precio == null && cantidad == null && fechaVencimiento == null){
            return ResponseEntity.badRequest().body(null);
        }

        Perecedero perecederoEncontrado = servicioPerecedero.buscarPerecedero(nombre,codigo,precio,cantidad,fechaVencimiento);

        if (perecederoEncontrado == null){
            ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(perecederoEncontrado);
    }

    @GetMapping("/delete")
    public ResponseEntity<String> eliminarPerecedero(){
        return ResponseEntity.ok("Ok");
    }

    @GetMapping("/list")
    public ResponseEntity<JsonNode> listarPerecederos() {
        JsonNode listaPerecederos = servicioPerecedero.listarPerecederos();

        if (listaPerecederos.isEmpty()) {
            return ResponseEntity.noContent().build();
        }

        return ResponseEntity.ok(listaPerecederos);
    }
}

