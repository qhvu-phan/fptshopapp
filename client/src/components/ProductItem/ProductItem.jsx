import React from "react";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { Button, CardActionArea, CardActions } from "@mui/material";
import { createTheme } from "@mui/material/styles";
import { Link } from "react-router-dom";
import "./ProductItem.css";
const ProductItem = (props) => {
  const product = props.productProps;
  const theme = createTheme({
    name: "#474c51",
    price: "#cb1c22",
  });
  return (
    <div className="product-item">
      <Card sx={{ maxWidth: 345 }}>
        <CardActionArea>
          <CardMedia
            component="img"
            height="200px"
            image={product.image}
            alt="green iguana"
          />
          <CardContent>
            <Typography
              gutterBottom
              variant="h5"
              component="div"
              color={theme.name}
            >
              {product.name}
            </Typography>
            <Typography
              gutterBottom
              variant="h5"
              component="div"
              color={theme.price}
            >
              {product.price} đ
            </Typography>
            <Typography variant="body2" color="text.secondary">
              {product.core} - {product.screen} - {product.ram} - {product.rom}
            </Typography>
          </CardContent>
        </CardActionArea>
        <CardActions>
          <Link to="/productdetails">
            <Button size="small" color="primary">
              Xem Thêm
            </Button>
          </Link>
          <Button size="small" color="primary">
            Mua Ngay
          </Button>
        </CardActions>
      </Card>
    </div>
  );
};

export default ProductItem;
