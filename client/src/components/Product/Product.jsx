import React from "react";
import ProductItem from "../ProductItem/ProductItem";
import "./Product.css";

const Product = () => {
  const array = [
    {
      image:
        "https://didongviet.vn/pub/media/catalog/product/i/p/iphone-13-pro-max-512gb-didongviet_1.jpg",
      name: "Iphone 13 Pro max",
      price: "27.777.777",
      core: "Apple A 14 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2022/3/17/637831052118762354_oppo-reno7-z-dd-2.jpg",
      name: "Oppo Reno7",
      price: "10.490.000",
      core: "Snapdragon 695",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2020/10/26/637393169370871358_ip-11-dd.png",
      name: "Iphone 11 64Gb",
      price: "12.999.777",
      core: "Apple A 13 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://didongviet.vn/pub/media/catalog/product/i/p/iphone-13-pro-max-512gb-didongviet_1.jpg",
      name: "Iphone 13 Pro max",
      price: "27.777.777",
      core: "Apple A 14 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2022/3/17/637831052118762354_oppo-reno7-z-dd-2.jpg",
      name: "Oppo Reno7",
      price: "10.490.000",
      core: "Snapdragon 695",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2020/10/26/637393169370871358_ip-11-dd.png",
      name: "Iphone 11 64Gb",
      price: "12.999.777",
      core: "Apple A 13 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://didongviet.vn/pub/media/catalog/product/i/p/iphone-13-pro-max-512gb-didongviet_1.jpg",
      name: "Iphone 13 Pro max",
      price: "27.777.777",
      core: "Apple A 14 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2022/3/17/637831052118762354_oppo-reno7-z-dd-2.jpg",
      name: "Oppo Reno7",
      price: "10.490.000",
      core: "Snapdragon 695",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2020/10/26/637393169370871358_ip-11-dd.png",
      name: "Iphone 11 64Gb",
      price: "12.999.777",
      core: "Apple A 13 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://didongviet.vn/pub/media/catalog/product/i/p/iphone-13-pro-max-512gb-didongviet_1.jpg",
      name: "Iphone 13 Pro max",
      price: "27.777.777",
      core: "Apple A 14 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      image:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2022/3/17/637831052118762354_oppo-reno7-z-dd-2.jpg",
      name: "Oppo Reno7",
      price: "10.490.000",
      core: "Snapdragon 695",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
    {
      immage:
        "https://images.fpt.shop/unsafe/fit-in/214x214/filters:quality(90):fill(white)/fptshop.com.vn/Uploads/Originals/2020/10/26/637393169370871358_ip-11-dd.png",
      name: "Iphone 11 64Gb",
      price: "12.999.777",
      core: "Apple A 13 Boanic",
      screen: "6.5in",
      ram: "4GB",
      rom: "256G",
    },
  ];

  return (
    <div className="product-container">
      {array.map((phone) => {
        return <ProductItem productProps={phone} />;
      })}
    </div>
  );
};

export default Product;
