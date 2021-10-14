let slide_index = 0
let slide_play = true
let slides = document.querySelectorAll('.slide')

hideAllSlide = () => {
    slides.forEach(e => {
        e.classList.remove('active')
    })
}

showSlide = () => {
    hideAllSlide()
    slides[slide_index].classList.add('active')
}

nextSlide = () => slide_index = slide_index + 1 === slides.length ? 0 : slide_index + 1

prevSlide = () => slide_index = slide_index - 1 < 0 ? slides.length - 1 : slide_index - 1

// pause slide when hover slider

document.querySelector('.slider').addEventListener('mouseover', () => slide_play = false)

// enable slide when mouse leave out slider
document.querySelector('.slider').addEventListener('mouseleave', () => slide_play = true)

// slider controll

document.querySelector('.slide-next').addEventListener('click', () => {
    nextSlide()
    showSlide()
})

document.querySelector('.slide-prev').addEventListener('click', () => {
    prevSlide()
    showSlide()
})

// slide controller

document.querySelector('.slide-next').addEventListener('click', () => {
    nextSlide()
    showSlide()
})

document.querySelector('.slide-prev').addEventListener('click', () => {
    prevSlide()
    showSlide()
})


showSlide()

// setInterval(() => {
//    if (!slide_play) return
//   nextSlide()
//    showSlide()
// }, 3000);


// render product

let product = [
    {
        name: 'JBL E55BT KEY BLACK',
        image1: './images/1.png',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'JBL JR 310BT',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'JBL TUNE 750BTNC',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'JBL Horizon',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'JBL Tune 220TWS',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'UA Project Rock',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
    {
        name: 'JBL Endurance SPRINT',
        image1: '',
        image2: '',
        old_price: '400',
        curr_price: '300'
    },
]

let product_list = document.querySelector('#latest-products')
let best_product_list = document.querySelector('#best-products')

product.forEach(e => {
    let prod = `
    <div class="col-3 col-md-6 col-sm-12">
    <div class="product-card">
        <div class="product-card-img">
            <img src="" alt="${e.image1}">
            <img src="${e.image2}" alt="">
        </div>
        <div class="product-card-info">
            <div class="product-btn">
                <button class="btn-flat btn-hover btn-shop-now">shop now</button>
                <button class="btn-flat btn-hover btn-cart-add">
                    <i class='bx bxs-cart-add' ></i>
                </button>
                <button class="btn-flat btn-hover btn-cart-add">
                    <i class='bx bxs-heart' ></i>
                </button>
            </div>
            <div class="product-card-name">
                ${e.name}
            </div>
            <div class="product-card-price">
                <span><del>${e.old_price}</del></span>
                <span class="curr-price">${e.curr_price}</span>
            </div>
        </div>
    </div>
</div>
    `
product_list.insertAdjacentHTML("beforeend", prod)
best_product_list.insertAdjacentHTML("afterbegin", prod)
})