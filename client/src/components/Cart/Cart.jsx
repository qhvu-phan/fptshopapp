import * as React from "react";
import { DataGrid, GridRowsProp, GridColDef } from "@mui/x-data-grid";
import { Button } from "@material-ui/core";
import Navbar from "../Navbar/Navbar";
import "./Cart.css";

const Cart = () => {
  const rows: GridRowsProp = [
    {
      id: 1,
      col1: "SP01",
      col2: "Iphone X",
      col3: "1",
      col4: "27.000.000vnđ",
      col5: "27.000.000vnđ",
    },
    {
      id: 2,
      col1: "SP01",
      col2: "Iphone X",
      col3: "1",
      col4: "27.000.000vnđ",
      col5: "27.000.000vnđ",
    },
    {
      id: 3,
      col1: "SP03",
      col2: "Iphone X",
      col3: "1",
      col4: "27.000.000vnđ",
      col5: "27.000.000vnđ",
    },
  ];

  const columns: GridColDef[] = [
    { field: "col1", headerName: "ID SP", width: 150 },
    { field: "col2", headerName: "TÊN SP", width: 150 },
    { field: "col3", headerName: "SỐ LƯỢNG", width: 150 },
    { field: "col4", headerName: "GIÁ", width: 150 },
    { field: "col5", headerName: "THÀNH TIỀN", width: 150 },
  ];

  return (
    <>
      <Navbar />
      <div className="cart-container">
        <div className="cart-title">
          Xin chào <b>Phan Quang Huy Vũ</b>
        </div>
        <div className="cart-info">
          Có <b>2</b> sản phẩm trong giỏ hàng của bạn!
        </div>
        <div style={{ height: 400, width: "100%" }}>
          <div style={{ display: "flex", height: "100%" }}>
            <div style={{ flexGrow: 1 }}>
              <DataGrid rows={rows} columns={columns} />
            </div>
          </div>
        </div>
        <div className="cart-total">
          Tồng tiền: <b>87.000.000vnđ</b>
        </div>
        <div style={{ textAlign: "center" }}>
          <Button
            style={{
              borderRadius: 35,
              backgroundColor: "#cb1c22",
              padding: "18px 40px",
              fontSize: "18px",
              margin: "0 10px",
            }}
            variant="contained"
          >
            Xác nhận đơn hàng
          </Button>
        </div>
      </div>
    </>
  );
};
export default Cart;
