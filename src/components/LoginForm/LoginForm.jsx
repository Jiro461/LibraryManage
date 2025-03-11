import React, { useState } from 'react'
import "./LoginForm.scss"
import {styled, TextField, Button } from "@mui/material"
import {useNavigate, Link} from "react-router-dom"

const IdentityNumberInput = styled(TextField)`
    margin-top: 20px;
` 

const LoginButton = styled(Button)`
    margin-top: 20px;
`

export default function LoginForm() {
    const [identityNumber, setIdentityNumber] = useState("")

    const navigate = useNavigate()

    const handleLogin = () => {
        console.log(identityNumber)
        console.log(name)

        //call api to login user
        navigate("/")
    }

  return (
    <div className='login-form'>
        <h3>Đăng nhập</h3>
        <IdentityNumberInput  placeholder='Nhập số căn cước công dân' label="Số căn cước công dân" value={identityNumber} onChange={(e) => setIdentityNumber(e.target.value)}></IdentityNumberInput>

        <LoginButton variant='contained' onClick={handleLogin}>Đăng nhập</LoginButton>

       <span style={{marginTop: "20px"}}>Chưa có tài khoản?<Link to="/register">Đăng kí thành viên</Link></span> 
    </div>
  )
}
