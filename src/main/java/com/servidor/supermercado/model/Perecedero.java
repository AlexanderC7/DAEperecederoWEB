package com.servidor.supermercado.model;


import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Positive;
import javax.validation.constraints.PositiveOrZero;
import java.time.LocalDateTime;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Perecedero {
    @NotBlank(message = "El nombre no puede estar vacío")
    private String nombre;

    @NotNull(message = "El código es obligatorio")
    @Positive(message = "El código debe ser un número positivo")
    private Integer codigo;

    @NotNull(message = "El precio es obligatorio")
    @PositiveOrZero(message = "El precio debe ser cero o positivo")
    private Double precio;

    @NotNull(message = "La cantidad es obligatoria")
    @PositiveOrZero(message = "La cantidad debe ser cero o positiva")
    private Integer cantidad;

    @NotNull(message = "La fecha de vencimiento es obligatoria")
    private LocalDateTime fechaVencimiento;
}
