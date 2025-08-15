# 💳 Adapter Design Pattern — Exemplo em C# 

Este projeto demonstra o uso do **Design Pattern Adapter** para integrar múltiplas APIs de pagamento (PayPal e Stripe) de forma unificada.

## 📌 Contexto do Problema
Imagine que seu sistema precisa processar pagamentos usando diferentes gateways (PayPal, Stripe, etc.).
Cada gateway possui **interfaces e métodos diferentes**, tornando o código difícil de manter e escalar.

## 🎯 Solução com Adapter
O padrão **Adapter** cria uma **interface padrão** (`IPaymentProcessor`) e adapta cada implementação de API para essa interface.
Assim, o restante do sistema não precisa conhecer os detalhes de cada API.

---

# 💳 Adapter Design Pattern — Example in C#

This project demonstrates the use of the **Adapter Design Pattern** to integrate multiple payment APIs (PayPal and Stripe) in a unified way.

## 📌 Problem Context
Imagine your system needs to process payments using different gateways (PayPal, Stripe, etc.).  
Each gateway has **different interfaces and methods**, making the code harder to maintain and scale.

## 🎯 Solution with Adapter
The **Adapter** pattern creates a **standard interface** (`IPaymentProcessor`) and adapts each API implementation to this interface.  
This way, the rest of the system does not need to know the specific details of each API.
