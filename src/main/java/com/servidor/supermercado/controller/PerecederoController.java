package com.servidor.supermercado.controller;

import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.datatype.jsr310.JavaTimeModule;
import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.services.ServicioPerecedero;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;
import java.util.List;

@RestController
@RequestMapping(value = "/perecederos")
public class PerecederoController {

    private ServicioPerecedero servicioPerecedero = new ServicioPerecedero();

    @GetMapping("/healthStatus")
    public ResponseEntity<String> devolverEstado(){
        return ResponseEntity.ok("OK");
    }

    @PostMapping
    public ResponseEntity<String> agregarPerecedero(@RequestBody Perecedero perecedero){
        if (perecedero == null) {
            ResponseEntity.badRequest().body("No es el objeto esperado");
        }

        boolean agregado = servicioPerecedero.agregarPerecedero(perecedero);

        if (agregado) {
            return ResponseEntity.ok("Agregado correctamente");
        } else {
            return ResponseEntity.internalServerError().body("No fue posible agregar");
        }
    }

    @GetMapping("/query")
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

    @DeleteMapping
    public ResponseEntity<String> eliminarPerecedero(@RequestParam Integer codigo) {
        if (codigo == null) {
            return ResponseEntity.badRequest().body("El código del perecedero no puede ser nulo");
        }
    
        boolean eliminado = servicioPerecedero.eliminarPerecedero(codigo);
    
        if (eliminado) {
            return ResponseEntity.ok("Perecedero eliminado correctamente");
        } else {
            return ResponseEntity.notFound().header("Eliminado","No").build();
        }
    }

    @PutMapping
    public ResponseEntity<String> actualizarPerecedero(@RequestBody Perecedero perecedero){
        if (perecedero == null) {
            return ResponseEntity.badRequest().body("No es el objeto esperado");
        }

        boolean actualizado = servicioPerecedero.actualizarPerecedero(perecedero);
        if (actualizado) {
            return ResponseEntity.ok("Actualizado");
        } else {
            return ResponseEntity.notFound().header("Actualizado", "No").build();
        }
    }

    @GetMapping
    public ResponseEntity<JsonNode> listarPerecederos() {
        JsonNode jsonPerecederos = servicioPerecedero.listarPerecederos();

        if (jsonPerecederos.isEmpty()) {
            return ResponseEntity.noContent().build();
        }

        return ResponseEntity.ok(jsonPerecederos);
    }

    @GetMapping("/filter")
    public ResponseEntity<JsonNode> listarPerecederosPorFiltro(@RequestParam(required = false) String nombre, @RequestParam(required = false) Integer codigo, @RequestParam(required = false) Double precio, @RequestParam(required = false) Integer cantidad, @RequestParam(required = false) LocalDateTime fechaVencimiento){
        if (nombre == null && codigo == null && precio == null && cantidad == null && fechaVencimiento == null){
            return ResponseEntity.badRequest().body(null);
        }

        JsonNode jsonPerecederos = servicioPerecedero.listarPerecederosPorFiltro(nombre, codigo, precio, cantidad, fechaVencimiento);

        if (jsonPerecederos == null) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(jsonPerecederos);

    }
}


