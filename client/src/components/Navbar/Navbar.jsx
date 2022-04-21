import React from "react";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import { Typography } from "@material-ui/core";
import TextField from "@mui/material/TextField";
import CircleNotificationsIcon from "@mui/icons-material/CircleNotifications";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import { Link } from "react-router-dom";
import "./Navbar.css";

const Navbar = () => {
  return (
    <AppBar className="nav">
      <Toolbar className="nav-content">
        <Typography variant="h2" noWrap component="label">
          HVShop
        </Typography>
        <TextField
          className="nav-content-textfield"
          label="Search"
          variant="outlined"
        />
        <Typography>
          <CircleNotificationsIcon className="nav-content-icon" />
          <Link to="/cart">
            <ShoppingCartIcon className="nav-content-icon" />
          </Link>
          <Link to="/login">
            <AccountCircleIcon className="nav-content-icon" />
          </Link>
        </Typography>
      </Toolbar>
    </AppBar>
  );
};
export default Navbar;
