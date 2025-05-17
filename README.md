# HotelReservationProject
---
![Udemy bitirme sertifikası](https://github.com/Suaybhizar/HotelReservationProject/assets/76668077/b7b12d5f-257a-40b4-8675-110b1004f5e8)

---

### Projenin içeriği

https://github.com/Suaybhizar/HotelReservationProject/assets/76668077/651bd52c-6479-4215-8cfb-4b731ea68577

# Otel Rezervasyon Projesi

## 📋 Proje Özeti

Otel Rezervasyon Projesi, .NET çerçevesi üzerine inşa edilmiş kapsamlı bir otel yönetim sistemidir. Otel rezervasyonlarının, müşteri bilgilerini ve oda müsaitliğinin yönetilmesini sağlar. Güvenli JWT tabanlı kimlik doğrulama, API tüketimi ve ön yüz kullanıcı arayüzlerini içeren eksiksiz bir çözümdür.

## ✨ Özellikler

* İş, veri erişimi ve DTO katmanları için modüler mimari.
* JWT kullanarak güvenli kimlik doğrulama.
* Harici hizmetlerle entegrasyon için API tüketimi (RapidAPI).
* Otel yönetimi için ön yüz kullanıcı arayüzleri.
* Görev yönetimi için ToDo listesi işlevselliği.
* Temiz mimari ve ölçeklenebilir geliştirme desteği.

## 🛠️ Kullanılan Teknolojiler

* **AspNet Core 5.0:** Yüksek performanslı, modüler ve çapraz platform destekli web uygulamaları geliştirmek için kullanılan framework.
* **MVC (Model-View-Controller) Mimari Yapısı:** Kullanıcı arayüzü (View), iş mantığı (Model) ve veri yönetimi (Controller) arasındaki ayrımı sağlayarak modüler bir geliştirme yaklaşımını destekler.
* **Entity Framework Core:** Veritabanı işlemlerini kolaylaştıran ve AspNet Core Identity ile güvenli kullanıcı kimlik doğrulaması sağlayan ORM.
* **DTO (Data Transfer Object) Sınıfları:** API katmanları arasında verimli veri aktarımı için kullanılan veri yapıları.
* **Swagger:** API dokümantasyonlarını otomatik olarak oluşturur ve test etmeyi kolaylaştırır, API uç noktalarını anlamayı ve hata ayıklamayı kolaylaştırır.
* **JWT (JSON Web Token) Yetkilendirme:** AspNet Core Identity ve JWT kullanarak güvenli ve taşınabilir kimlik doğrulama sağlar.
* **Rapid API:** Otel rezervasyonları, döviz kurları, uçuş bilgileri ve sosyal medya metrikleri gibi dış veri kaynaklarına entegrasyon sağlar.
* **E-Posta Entegrasyonu:** Rezervasyon onayları için e-posta bildirimlerini destekler ve AspNet Core Identity ile entegredir.
* **Çok Katmanlı Mimari:** İş mantığı, veri erişimi ve kullanıcı arayüzü gibi farklı katmanları ayırarak ölçeklenebilir ve bakımı kolay kod yapısı sağlar.

## 📁 Proje Yapısı

```
HotelReservationProject.sln
├── ApiConsume (API Entegrasyon Katmanı)
├── Frontend (Kullanıcı Arayüzü)
├── JwtProject (Kimlik Doğrulama)
├── RapidApi (Harici API Entegrasyonu)
├── ToDoList (Görev Yönetimi)
└── HotelProject (Temel İş Mantığı)
    ├── HotelProject.BusinessLayer
    ├── HotelProject.DataAccessLayer
    ├── HotelProject.DtoLayer
    ├── HotelProject.EntityLayer
    └── HotelProject.WebUI (Web Ön Yüzü)
```

## 🚀 Başlangıç

1. Depoyu klonlayın:

```bash
git clone https://github.com/your-username/HotelReservationProject.git
cd HotelReservationProject
```

2. Çözümü Visual Studio'da açın.
3. NuGet paketlerini geri yükleyin:

```bash
dotnet restore
```

4. Migration oluşturun ve veritabanını güncelleyin:

```powershell
# Migration oluşturma
Add-Migration InitialCreate -Project HotelProject.DataAccessLayer -StartupProject HotelProject.WebUI

# Veritabanını güncelleme
Update-Database -Project HotelProject.DataAccessLayer -StartupProject HotelProject.WebUI
```

5. Projeyi çalıştırın:

```bash
dotnet run
```

## 🤝 Katkıda Bulunma

Katkılar memnuniyetle karşılanır! İyileştirmeler ve hata düzeltmeleri için bir pull request oluşturabilir veya bir issue açabilirsiniz.

## 📄 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.

<br/>

# Hotel Reservation Project

## 📋 Project Overview

The Hotel Reservation Project is a comprehensive hotel management system built on the .NET framework. It provides a complete solution for managing hotel reservations, customer details, and room availability, including secure JWT-based authentication, API consumption, and frontend user interfaces.

## ✨ Features

* Modular architecture with separate layers for business, data access, and DTOs.
* Secure authentication using JWT.
* API consumption for integrating external services (RapidAPI).
* Frontend user interfaces for hotel management.
* ToDo list functionality for task management.
* Support for clean architecture and scalable development.

## 🛠️ Technologies Used

* **AspNet Core 5.0:** A high-performance, modular, and cross-platform framework for building web applications.
* **MVC (Model-View-Controller) Architecture:** Provides a modular development approach by separating user interface (View), business logic (Model), and data management (Controller).
* **Entity Framework Core:** Simplifies database operations and integrates with AspNet Core Identity for secure user authentication.
* **DTO (Data Transfer Object) Classes:** Efficient data structures for transferring data between API layers.
* **Swagger:** Automatically generates API documentation, making it easier to understand and test API endpoints.
* **JWT (JSON Web Token) Authorization:** Provides secure and portable authentication using AspNet Core Identity and JWT tokens.
* **Rapid API:** Integrates with external data sources like hotel reservations, exchange rates, flight information, and social media metrics.
* **Email Integration:** Supports sending reservation confirmations via email, integrated with AspNet Core Identity.
* **Multi-Layered Architecture:** Separates business logic, data access, and user interfaces for scalable and maintainable code.

## 📁 Project Structure

```
HotelReservationProject.sln
├── ApiConsume (API Integration Layer)
├── Frontend (User Interface)
├── JwtProject (Authentication)
├── RapidApi (External API Integration)
├── ToDoList (Task Management)
└── HotelProject (Core Business Logic)
    ├── HotelProject.BusinessLayer
    ├── HotelProject.DataAccessLayer
    ├── HotelProject.DtoLayer
    ├── HotelProject.EntityLayer
    └── HotelProject.WebUI (Web Frontend)
```

## 🚀 Getting Started

1. Clone the repository:

```bash
git clone https://github.com/your-username/HotelReservationProject.git
cd HotelReservationProject
```

2. Open the solution in Visual Studio.
3. Restore NuGet packages:

```bash
dotnet restore
```

4. Create the initial migration and update the database:

```powershell
# Create the initial migration
Add-Migration InitialCreate -Project HotelProject.DataAccessLayer -StartupProject HotelProject.WebUI

# Update the database
Update-Database -Project HotelProject.DataAccessLayer -StartupProject HotelProject.WebUI
```

5. Run the project:

```bash
dotnet run
```

## 🤝 Contributing

Contributions are welcome! Please create a pull request or open an issue for improvements and bug fixes.

## 📄 License

This project is licensed under the MIT License.




