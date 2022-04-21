import React from "react";
import { Box, TextField } from "@material-ui/core";
import { Button } from "@material-ui/core";
import { Link } from "react-router-dom";
import "./Register.css";

const Register = () => {
  return (
    <div className="login_container">
      <div className="login_image">
        <img
          src="https://dongphucnhattam.com/wp-content/uploads/2020/07/mau-ao-thun-nhan-vien-fpt-dep.jpg"
          alt=""
        />
      </div>
      <div className="login_info">
        <div className="login_title">Đăng Ký</div>
        <Box
          component="form"
          sx={{
            "& .MuiTextField-root": { m: 1, width: "25ch" },
          }}
          noValidate
          autoComplete="off"
        >
          <div className="login_user">
            <TextField
              id="standard-basic"
              label="Số điện thoại"
              variant="standard"
            />
          </div>
          <div className="login_password">
            <TextField
              id="standard-basic"
              label="Mật Khẩu"
              variant="standard"
            />
          </div>
          <div className="login_password">
            <TextField id="standard-basic" label="Email" variant="standard" />
          </div>
          <div className="login_password">
            <TextField id="standard-basic" label="Địa chỉ" variant="standard" />
          </div>
        </Box>
        <Button
          style={{
            borderRadius: 35,
            backgroundColor: "#21b6ae",
            padding: "9px 18px",
            fontSize: "18px",
            margin: "0 10px 20px 10px",
            marginRight: "0",
          }}
          variant="contained"
        >
          Đăng ký
        </Button>
        <div>
          <Link to="/login">
            <Button
              style={{
                borderRadius: 35,
                padding: "9px 18px",
                fontSize: "18px",
                margin: "0 10px",
                marginRight: "0",
              }}
              variant="contained"
            >
              Bạn đã có tài khoản
            </Button>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default Register;
