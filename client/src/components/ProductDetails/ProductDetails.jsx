import React from "react";
import Navbar from "../Navbar/Navbar";
import { Button } from "@material-ui/core";
import TableProductDetails from "../TableProductDetails/TableProductDetails";
import "./Product.css";
import { Rating } from "@mui/material";
import Comments from "../Comments/Comments";

const ProductDetails = () => {
  return (
    <>
      <Navbar />
      <div className="product_deatails_container">
        <div className="product_main">
          <div className="product_image">
            <div className="product_title">Iphone X</div>
            <div className="image">
              <img
                src="https://fptshop.com.vn/landing-samsung-galaxy-a73/images/spec-img.png?v=3hctcKpS6VC3glOsIP8gr8D5pAnNzHd3PQh2BR4IrEw"
                alt=""
              />
            </div>
            <div className="product_price">
              Giá chính thức: <b style={{ color: "#cb1c22" }}>27.670.000vnđ</b>
            </div>
            <div className="button">
              <Button
                style={{
                  borderRadius: 35,
                  backgroundColor: "#21b6ae",
                  padding: "18px 36px",
                  fontSize: "18px",
                  margin: "0 10px",
                }}
                variant="contained"
              >
                Thêm vào giỏ hàng
              </Button>
              <Button
                style={{
                  borderRadius: 35,
                  backgroundColor: "#cb1c22",
                  padding: "18px 36px",
                  fontSize: "18px",
                  margin: "0 10px",
                }}
                variant="contained"
              >
                Mua ngay
              </Button>
            </div>
          </div>
          <div className="product_info">
            <div className="info_title">Thông số kỹ thuật</div>
            <div>
              <TableProductDetails />
            </div>
          </div>
        </div>
        <div className="product_rating_comment">
          <Rating />
          <Comments />
        </div>
      </div>
    </>
  );
};

export default ProductDetails;
