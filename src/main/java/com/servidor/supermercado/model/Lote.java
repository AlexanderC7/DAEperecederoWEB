package com.servidor.supermercado.model;

import jakarta.persistence.*;
import lombok.*;
import javax.validation.constraints.*;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "LOTE")
public class Lote {

    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "lote_seq")
    @SequenceGenerator(name = "lote_seq", sequenceName = "LOTE_SEQ", allocationSize = 1)
    private Long id;

    @NotNull(message = "El número de lote es obligatorio")
    private Integer numLote;

    @NotBlank(message = "El proveedor no puede estar vacío")
    private String proveedor;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "perecedero_id", nullable = false)
    @ToString.Exclude
    @EqualsAndHashCode.Exclude
    private Perecedero perecedero;
}