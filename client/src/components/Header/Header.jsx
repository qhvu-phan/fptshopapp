import React from "react";
import PhoneIphoneIcon from "@mui/icons-material/PhoneIphone";
import LaptopIcon from "@mui/icons-material/Laptop";
import AppleIcon from "@mui/icons-material/Apple";
import HeadphonesIcon from "@mui/icons-material/Headphones";
import HomeIcon from "@mui/icons-material/Home";
import SdCardIcon from "@mui/icons-material/SdCard";
import MonetizationOnIcon from "@mui/icons-material/MonetizationOn";
import "./Header.css";

const Header = () => {
  const array = [
    { icon: PhoneIphoneIcon, tilte: "Điện thoại" },
    { icon: LaptopIcon, tilte: "Laptop" },
    { icon: AppleIcon, tilte: "Apple" },
    { icon: HeadphonesIcon, tilte: "Linh kiện" },
    { icon: HomeIcon, tilte: "Hàng gia dụng" },
    { icon: SdCardIcon, tilte: "Sim và thẻ ĐT" },
    { icon: MonetizationOnIcon, tilte: "Trả góp 0đ" },
  ];
  return (
    <div className="header">
      <ul className="header-item">
        {array.map((item) => {
          return (
            <li>
              {<item.icon />} {item.tilte}
            </li>
          );
        })}
      </ul>
    </div>
  );
};

export default Header;
