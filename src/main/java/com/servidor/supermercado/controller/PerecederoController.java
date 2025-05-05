package com.servidor.supermercado.controller;

import com.fasterxml.jackson.databind.JsonNode;
import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.services.ServicioPerecedero;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.time.LocalDateTime;
import java.util.List;
import java.util.stream.Collectors;

@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping("/perecederos")
public class PerecederoController {

    private final ServicioPerecedero servicioPerecedero = new ServicioPerecedero();

    @GetMapping("/healthStatus")
    public ResponseEntity<String> devolverEstado() {
        return ResponseEntity.ok("OK");
    }

    @PostMapping("/")
    public ResponseEntity<?> agregarPerecedero(@Valid @RequestBody Perecedero perecedero, BindingResult result) {
        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(error -> error.getField() + ": " + error.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        boolean agregado = servicioPerecedero.agregarPerecedero(perecedero);
        if (agregado) {
            return ResponseEntity.ok("Agregado correctamente");
        } else {
            return ResponseEntity.internalServerError().body("No fue posible agregar");
        }
    }

    @PutMapping("/")
    public ResponseEntity<?> actualizarPerecedero(@Valid @RequestBody Perecedero perecedero, BindingResult result) {
        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(error -> error.getField() + ": " + error.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        boolean actualizado = servicioPerecedero.actualizarPerecedero(perecedero);
        if (actualizado) {
            return ResponseEntity.ok("Perecedero actualizado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("No encontrado");
        }
    }

    @GetMapping("/query")
    public ResponseEntity<?> buscarPerecedero(
            @RequestParam(required = false) String nombre,
            @RequestParam(required = false) Integer codigo,
            @RequestParam(required = false) Double precio,
            @RequestParam(required = false) Integer cantidad,
            @RequestParam(required = false) LocalDateTime fechaVencimiento) {

        if (nombre == null && codigo == null && precio == null && cantidad == null && fechaVencimiento == null) {
            return ResponseEntity.badRequest().body("Debe proporcionar al menos un criterio de búsqueda");
        }

        Perecedero encontrado = servicioPerecedero.buscarPerecedero(nombre, codigo, precio, cantidad, fechaVencimiento);
        if (encontrado == null) return ResponseEntity.status(HttpStatus.NOT_FOUND).build();

        return ResponseEntity.ok(encontrado);
    }

    @DeleteMapping("/{codigo}")
    public ResponseEntity<String> eliminarPerecedero(@PathVariable Integer codigo) {
        if (codigo == null || codigo <= 0) {
            return ResponseEntity.badRequest().body("El código del perecedero debe ser un número positivo");
        }

        boolean eliminado = servicioPerecedero.eliminarPerecedero(codigo);
        if (eliminado) {
            return ResponseEntity.ok("Perecedero eliminado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("No encontrado");
        }
    }

    @GetMapping("/")
    public ResponseEntity<?> listarPerecederosPorFiltro(
            @RequestParam(required = false) String nombre,
            @RequestParam(required = false) Integer codigo,
            @RequestParam(required = false) Double precio,
            @RequestParam(required = false) Integer cantidad,
            @RequestParam(required = false) LocalDateTime fechaVencimiento) {

        JsonNode json;
        if (nombre == null && codigo == null && precio == null && cantidad == null && fechaVencimiento == null) {
            json = servicioPerecedero.listarPerecederos();
        } else {
            json = servicioPerecedero.listarPerecederosPorFiltro(nombre, codigo, precio, cantidad, fechaVencimiento);
        }

        if (json == null || json.isEmpty()) {
            return ResponseEntity.noContent().build();
        }

        return ResponseEntity.ok(json);
    }
}
