package com.servidor.supermercado.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping(value = "/perecederos")
public class PerecederoController {

    @GetMapping("/")
    public String devolverPrincipal(){
        return "Perecederos";
    }

    @GetMapping("/healthStatus")
    public String devolverEstado(){
        return "Estado: OK";
    }

}
