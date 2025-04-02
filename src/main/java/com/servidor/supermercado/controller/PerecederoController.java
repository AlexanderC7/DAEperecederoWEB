package com.servidor.supermercado.controller;

import com.servidor.supermercado.model.Perecedero;
import com.servidor.supermercado.services.ServicioPerecedero;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping(value = "/perecederos")
public class PerecederoController {

    private ServicioPerecedero servicioPerecedero;

    @GetMapping("/")
    public String devolverPrincipal(){
        return "Perecederos";
    }

    @GetMapping("/healthStatus")
    public String devolverEstado(){
        return "Estado: OK";
    }

    @GetMapping("/find")
    public String buscarPerecedero(){
        String respuesta;
        respuesta = servicioPerecedero.getPerecederos().toString();
        return respuesta;
    }

}
