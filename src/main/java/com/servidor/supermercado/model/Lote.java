package com.servidor.supermercado.model;

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;
import lombok.*;
import javax.validation.constraints.*;
import java.time.LocalDateTime;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "LOTE")
public class Lote {

    @JsonIgnore
    @EmbeddedId
    private LoteId id;

    @Transient // Este campo no se guarda directamente en la base de datos
    private Integer numLote;

    @NotBlank(message = "El proveedor no puede estar vacío")
    private String proveedor;

    @NotNull(message = "La fecha de abastecimiento es obligatoria")
    @Column(name = "fecha_abastecimiento", nullable = false)
    private LocalDateTime fechaAbastecimiento;

    @MapsId("perecederoCodigo")
    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "perecedero_codigo", nullable = false)
    @ToString.Exclude
    @EqualsAndHashCode.Exclude
    @JsonBackReference
    private Perecedero perecedero;

    // Getter personalizado para exponer numLote directamente
    public Integer getNumLote() {
        return id != null ? id.getNumLote() : null;
    }
}