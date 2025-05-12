package com.servidor.supermercado.controller;

import com.servidor.supermercado.model.Lote;
import com.servidor.supermercado.services.ServicioLote;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping("/lotes")
public class LoteController {

    @Autowired
    private ServicioLote servicioLote;

    @PostMapping("/{perecederoId}")
    public ResponseEntity<?> agregarLote(
            @PathVariable Long perecederoId,
            @Valid @RequestBody Lote lote,
            BindingResult result) {

        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(err -> err.getField() + ": " + err.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        Lote creado = servicioLote.guardarLote(perecederoId, lote);
        if (creado != null) {
            return ResponseEntity.ok("Lote agregado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND)
                    .body("No se encontró el Perecedero con ID: " + perecederoId);
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<?> actualizarLote(
            @PathVariable Long id,
            @Valid @RequestBody Lote lote,
            BindingResult result) {

        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(err -> err.getField() + ": " + err.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        boolean actualizado = servicioLote.actualizarLote(id, lote);
        if (actualizado) {
            return ResponseEntity.ok("Lote actualizado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Lote no encontrado");
        }
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> obtenerLotePorId(@PathVariable Long id) {
        Optional<Lote> lote = servicioLote.buscarPorId(id);
        return lote.map(ResponseEntity::ok)
                .orElseGet(() -> ResponseEntity.status(HttpStatus.NOT_FOUND).build());
    }

    @GetMapping("/perecedero/{perecederoId}")
    public ResponseEntity<?> obtenerLotesPorPerecedero(@PathVariable Long perecederoId) {
        List<Lote> lotes = servicioLote.buscarPorPerecedero(perecederoId);
        if (lotes.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(lotes);
    }

    @GetMapping("/")
    public ResponseEntity<?> listarTodos() {
        List<Lote> lotes = servicioLote.listarTodos();
        if (lotes.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(lotes);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> eliminarLote(@PathVariable Long id) {
        boolean eliminado = servicioLote.eliminarLote(id);
        if (eliminado) {
            return ResponseEntity.ok("Lote eliminado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Lote no encontrado");
        }
    }
}