package com.servidor.supermercado.model;

import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import lombok.*;
import javax.validation.constraints.*;
import java.time.LocalDateTime;
import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "PERECEDERO")
public class Perecedero {

    @Id
    @Column(name = "codigo", nullable = false, unique = true)
    @NotNull(message = "El código es obligatorio")
    @Positive(message = "El código debe ser un número positivo")
    private Integer codigo;

    @NotBlank(message = "El nombre no puede estar vacío")
    @Column(nullable = false)
    private String nombre;

    @NotNull(message = "El precio es obligatorio")
    @PositiveOrZero(message = "El precio debe ser cero o positivo")
    private Double precio;

    @NotNull(message = "La cantidad es obligatoria")
    @PositiveOrZero(message = "La cantidad debe ser cero o positiva")
    private Integer cantidad;

    @NotNull(message = "La fecha de vencimiento es obligatoria")
    @Column(name = "fecha_vencimiento", nullable = false)
    private LocalDateTime fechaVencimiento;

    @OneToMany(mappedBy = "perecedero", cascade = CascadeType.ALL, orphanRemoval = true)
    @JsonManagedReference
    private List<Lote> lotes;
}
