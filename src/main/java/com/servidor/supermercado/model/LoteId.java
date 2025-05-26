package com.servidor.supermercado.model;

import jakarta.persistence.*;
import lombok.*;

import java.io.Serializable;
import java.util.Objects;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Embeddable
public class LoteId implements Serializable {

    private Integer numLote;

    private Integer perecederoCodigo;

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof LoteId that)) return false;
        return Objects.equals(numLote, that.numLote) &&
                Objects.equals(perecederoCodigo, that.perecederoCodigo);
    }

    @Override
    public int hashCode() {
        return Objects.hash(numLote, perecederoCodigo);
    }
}