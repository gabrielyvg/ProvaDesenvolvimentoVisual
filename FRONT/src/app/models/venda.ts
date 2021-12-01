import { ItemVenda } from 'src/app/models/item-venda';
export interface Venda {
    vendaId?: number;
    cliente: string;
    ItemVenda: string;
    pagamentoId: number;
    criadoem?: string;
}

