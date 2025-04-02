package com.servidor.supermercado.model;


import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDateTime;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Perecedero {
    private String nombre;
    private Integer codigo;
    private Double precio;
    private Integer cantidad;
    private LocalDateTime fechaVencimiento;
}
