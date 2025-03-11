import React, { useState } from 'react'
import "./RegisterForm.scss"
import {styled, TextField, Button } from "@mui/material"
import {useNavigate} from "react-router-dom"

const IdentityNumberInput = styled(TextField)`
    margin-top: 20px;
` 

const LoginButton = styled(Button)`
    margin-top: 20px;
`

export default function RegisterForm() {
    const [identityNumber, setIdentityNumber] = useState("")
    const [name, setName] = useState("")

    const navigate = useNavigate()

    const handleLogin = () => {
        console.log(identityNumber)
        console.log(name)

        //call api to login user
        navigate("/")
    }

  return (
    <div className='register-form'>
        <h3>Đăng kí thành viên</h3>
        <IdentityNumberInput  placeholder='Nhập số căn cước công dân' label="Số căn cước công dân" value={identityNumber} onChange={(e) => setIdentityNumber(e.target.value)}></IdentityNumberInput>
        <IdentityNumberInput  placeholder='Nhập họ và tên của bạn' label="Họ và tên" value={name} onChange={(e) => setName(e.target.value)}></IdentityNumberInput>

        <LoginButton variant='contained' onClick={handleLogin}>Đăng ký thành viên</LoginButton>
    </div>
  )
}
