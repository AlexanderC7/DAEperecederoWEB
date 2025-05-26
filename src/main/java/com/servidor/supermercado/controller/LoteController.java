package com.servidor.supermercado.controller;

import com.servidor.supermercado.model.Lote;
import com.servidor.supermercado.model.LoteId;
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

    // Crear un nuevo lote
    @PostMapping("/{perecederoCodigo}")
    public ResponseEntity<?> agregarLote(
            @PathVariable Integer perecederoCodigo,
            @Valid @RequestBody Lote lote,
            BindingResult result) {

        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(err -> err.getField() + ": " + err.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        Lote creado = servicioLote.guardarLote(perecederoCodigo, lote);
        if (creado != null) {
            return ResponseEntity.ok("Lote agregado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND)
                    .body("No se encontró el Perecedero con código: " + perecederoCodigo);
        }
    }

    // Actualizar un lote
    @PutMapping("/{numLote}/{perecederoCodigo}")
    public ResponseEntity<?> actualizarLote(
            @PathVariable Integer numLote,
            @PathVariable Integer perecederoCodigo,
            @Valid @RequestBody Lote lote,
            BindingResult result) {

        if (result.hasErrors()) {
            List<String> errores = result.getFieldErrors().stream()
                    .map(err -> err.getField() + ": " + err.getDefaultMessage())
                    .collect(Collectors.toList());
            return ResponseEntity.badRequest().body(errores);
        }

        LoteId id = new LoteId(numLote, perecederoCodigo);
        boolean actualizado = servicioLote.actualizarLote(id, lote);
        if (actualizado) {
            return ResponseEntity.ok("Lote actualizado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Lote no encontrado");
        }
    }

    // Obtener un lote por ID compuesto
    @GetMapping("/{numLote}/{perecederoCodigo}")
    public ResponseEntity<?> obtenerLotePorId(
            @PathVariable Integer numLote,
            @PathVariable Integer perecederoCodigo) {

        LoteId id = new LoteId(numLote, perecederoCodigo);
        Optional<Lote> lote = servicioLote.buscarPorId(id);
        return lote.map(ResponseEntity::ok)
                .orElseGet(() -> ResponseEntity.status(HttpStatus.NOT_FOUND).build());
    }

    // Obtener lotes por perecedero
    @GetMapping("/perecedero/{perecederoCodigo}")
    public ResponseEntity<?> obtenerLotesPorPerecedero(@PathVariable Integer perecederoCodigo) {
        List<Lote> lotes = servicioLote.buscarPorPerecedero(perecederoCodigo);
        if (lotes.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(lotes);
    }

    // Listar todos los lotes
    @GetMapping("/")
    public ResponseEntity<?> listarTodos() {
        List<Lote> lotes = servicioLote.listarTodos();
        if (lotes.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(lotes);
    }

    // Eliminar lote
    @DeleteMapping("/{numLote}/{perecederoCodigo}")
    public ResponseEntity<?> eliminarLote(
            @PathVariable Integer numLote,
            @PathVariable Integer perecederoCodigo) {

        LoteId id = new LoteId(numLote, perecederoCodigo);
        boolean eliminado = servicioLote.eliminarLote(id);
        if (eliminado) {
            return ResponseEntity.ok("Lote eliminado correctamente");
        } else {
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Lote no encontrado");
        }
    }
}