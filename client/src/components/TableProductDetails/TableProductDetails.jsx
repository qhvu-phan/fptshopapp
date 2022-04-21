import React from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";

const TableProductDetails = () => {
  const product = [
    { key: "Màn hình", value: "6.7 inch FHD+ Infinity-O Super AMOLED 120Hz" },
    {
      key: "Camera Sau",
      value: "108.0 MP + 12.0 MP + 5.0 MP + 5.0 MP Chống rung quang học (OIS)",
    },
    {
      key: "Camera Selfie",
      value: "32.0 MP",
    },
    {
      key: "CPU",
      value: "Snapdragon 778G (6nm)",
    },
    {
      key: "RAM",
      value: "8GB",
    },
    {
      key: "Bộ nhớ trong",
      value: "32GB",
    },
    {
      key: "Dung lượng pin",
      value: "5000 mAh, Sạc nhanh 25W",
    },
    {
      key: "Hệ điều hành",
      value: "IOS",
    },
    {
      key: "Tính năng khác",
      value: "Chuẩn kháng bụi, kháng nước IP67",
    },
  ];
  const rows = [];
  function createData(calories, fat) {
    return { calories, fat };
  }
  product.map((item) => {
    let row = createData(item.key, item.value);
    rows.push(row);
  });
  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableBody>
          {rows.map((row) => (
            <TableRow
              key={row.name}
              sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
            >
              <TableCell align="left">{row.calories}</TableCell>
              <TableCell align="left">{row.fat}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default TableProductDetails;
