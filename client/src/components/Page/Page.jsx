import React from "react";
import Header from "../Header/Header";
import Navbar from "../Navbar/Navbar";
import Product from "../Product/Product";
import Slider from "../Slider/Slider.jsx";
const Page = () => {
  return (
    <>
      <Navbar />
      <Header />
      <Slider />
      <Product />
    </>
  );
};

export default Page;
