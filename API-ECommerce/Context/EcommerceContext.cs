using System;
using System.Collections.Generic;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ECommerce.Context;

public partial class EcommerceContext : DbContext
{
    public EcommerceContext()
    {
    }

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ItemPedido> ItemPedidos { get; set; }

    public virtual DbSet<Pagamento> Pagamentos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =NOTE46-S28;Initial Catalog=ECommerce; User Id=sa;Password=Senai@134;trustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D5946642B2183619");

            entity.ToTable("Cliente");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NomeCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemPedido>(entity =>
        {
            entity.HasKey(e => e.IdItemPedido).HasName("PK__ItemPedi__F77088BAEF618D83");

            entity.ToTable("ItemPedido");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.ItemPedidos)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__ItemPedid__IdPed__66603565");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ItemPedidos)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("FK__ItemPedid__IdPro__6754599E");
        });

        modelBuilder.Entity<Pagamento>(entity =>
        {
            entity.HasKey(e => e.IdPagamento).HasName("PK__Pagament__D474651ED43F004D");

            entity.ToTable("Pagamento");

            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.FormaDePagamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.Pagamentos)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__Pagamento__IdPed__619B8048");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedido__9D335DC32867377C");

            entity.ToTable("Pedido");

            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Pedido__IdClient__5EBF139D");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("PK__Produto__2E883C23B4594CDD");

            entity.ToTable("Produto");

            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("decimal(18, 6)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
