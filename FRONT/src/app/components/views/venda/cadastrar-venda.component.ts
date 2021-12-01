import { PagamentoService } from './../../../services/pagamento.service';
import { Pagamento } from './../../../models/pagamento';
import { VendaService } from './../../../services/venda.service';
import { Venda } from './../../../models/venda';
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";


@Component({
    selector: "app-cadastrar-venda",
    templateUrl: "./cadastrar-venda.component.html",
    styleUrls: ["./cadastrar-venda.component.css"],
})
export class CadastrarVendaComponent implements OnInit {

    vendaId!: number;
    cliente!: string;
    ItemVenda!: string;
    pagamentoId!: number;
    pagamentos!: Pagamento[];
    criadoem!: string;

    constructor(
        private router: Router,
        private VendaService : VendaService,    
        private PagamentoService : PagamentoService
    ) {}
    ngOnInit(): void {
        this.PagamentoService.list().subscribe((pagamentos: Pagamento[]) => {
            this.pagamentos = pagamentos;
     });
    }
    cadastrar(): void {
        let venda: Venda = {
            cliente: this.cliente,
            ItemVenda: this.ItemVenda,
            pagamentoId: this.pagamentoId,
        };
        this.VendaService.create(venda).subscribe((venda: any) => {
            console.log(venda);
            this.router.navigate(["venda/listar"]);
        });
    }
}

   
